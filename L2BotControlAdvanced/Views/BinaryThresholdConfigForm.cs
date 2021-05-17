using L2BotControlAdvanced.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L2BotControlAdvanced.Views
{
    public partial class BinaryThresholdConfigForm : Form
    {
        private readonly IConfigService _configService;

        public BinaryThresholdConfigForm(IConfigService configService)
        {
            _configService = configService;

            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

        }
    }
}
