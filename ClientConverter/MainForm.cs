using OpenTibia.Client;
using OpenTibia.Client.Things;
using OpenTibia.Core;
using OpenTibia.Utils;
using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace ClientConverter
{
    public partial class MainForm : Form
    {
        #region | Constructor |

        private VersionStorage versions;
        private ClientImpl client;

        #endregion

        #region | Constructor |

        public MainForm()
        {
            this.InitializeComponent();
            this.LoadVersions();
        }

        #endregion

        #region | Private Methods |

        private void LoadVersions()
        {
            try
            {
                this.versions = new VersionStorage();
                this.versions.Load(@"versions.xml");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            this.inputVersionComboBox.Items.AddRange(this.versions.GetAllVersions());
            this.inputVersionComboBox.SelectedIndex = 0;

            this.outputVersionComboBox.Items.AddRange(this.versions.GetAllVersions());
            this.outputVersionComboBox.SelectedIndex = 0;
        }

        #endregion

        #region | Event Handlers |

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo version = FileVersionInfo.GetVersionInfo(assembly.Location);
            this.Text = "ClientConverter " + version.FileVersion;
        }

        private void InputVersionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            OpenTibia.Core.Version version = (OpenTibia.Core.Version)this.inputVersionComboBox.SelectedItem;
            this.inputFrameDurationsCheckBox.Checked = (ushort)version.Format >= (ushort)DatFormat.Format_1050;
            this.inputFrameGroupsCheckBox.Checked = (ushort)version.Format >= (ushort)DatFormat.Format_1057;
        }

        private void OutputVersionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            OpenTibia.Core.Version version = (OpenTibia.Core.Version)this.outputVersionComboBox.SelectedItem;
            this.outputFrameDurationsCheckBox.Checked = (ushort)version.Format >= (ushort)DatFormat.Format_1050;
            this.outputFrameDurationsCheckBox.Enabled = (ushort)version.Format >= (ushort)DatFormat.Format_1050;
            this.outputFrameGroupsCheckBox.Checked = (ushort)version.Format >= (ushort)DatFormat.Format_1057;
            this.outputFrameGroupsCheckBox.Enabled = (ushort)version.Format >= (ushort)DatFormat.Format_1057;
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            string directory = Path.Combine(PathUtils.ApplicationDirectory, "Input");
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            if (this.client != null)
            {
                this.client.Dispose();
                this.client = null;
            }

            OpenTibia.Core.Version version = (OpenTibia.Core.Version)this.inputVersionComboBox.SelectedItem;
            string datPath = Path.Combine(directory, "Tibia.dat");
            string sprPath = Path.Combine(directory, "Tibia.spr");

            try
            {
                this.client = new ClientImpl();
                this.client.ClientLoaded += new EventHandler(this.ClientLoaded_Handler);
                this.client.ProgressChanged += new ProgressHandler(this.ClientProgress_Handler);
                this.client.ClientCompiled += new EventHandler(this.ClientCompiled_Handler);
                this.client.Load(datPath, sprPath, version);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Selected client: " + version + ".\n\n" + ex.Message);
                Application.Exit();
            }
        }

        private void CompileButton_Click(object sender, EventArgs e)
        {
            string directory = Path.Combine(PathUtils.ApplicationDirectory, "Output");
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            OpenTibia.Core.Version version = (OpenTibia.Core.Version)this.outputVersionComboBox.SelectedItem;
            string datPath = Path.Combine(directory, "Tibia.dat");
            string sprPath = Path.Combine(directory, "Tibia.spr");
            ClientFeatures features = ClientFeatures.PatternZ | ClientFeatures.Extended;
            features |= this.outputFrameDurationsCheckBox.Checked ? ClientFeatures.FrameDurations : features;
            features |= this.outputFrameGroupsCheckBox.Checked ? ClientFeatures.FrameGroups : features;

            try
            {
                this.compileButton.Enabled = false;
                this.client.Save(datPath, sprPath, version, features);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
        }

        private void ClientLoaded_Handler(object sender, EventArgs e)
        {
            this.loadButton.Enabled = false;
            this.loadProgressBar.Value = 100;
            this.compileButton.Enabled = this.client.Loaded;
        }

        private void ClientProgress_Handler(object sender, int percentage)
        {
            this.compileProgressBar.Value = percentage;
        }

        private void ClientCompiled_Handler(object sender, EventArgs e)
        {
            this.loadButton.Enabled = this.client.Loaded;
            this.compileButton.Enabled = this.client.Loaded;
            this.compileProgressBar.Value = 100;
        }

        #endregion
    }
}
