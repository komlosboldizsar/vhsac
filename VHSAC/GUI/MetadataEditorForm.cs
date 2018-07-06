using System;
using System.Windows.Forms;
using VHSAC.Model.Metadata;

namespace VHSAC.GUI
{
    public partial class MetadataEditorForm : Form
    {

        private CaptureMetadata _editedStruct;

        public MetadataEditorForm(CaptureMetadata editedStruct)
        {
            _editedStruct = editedStruct;
            InitializeComponent();
        }

        private void load()
        {
            titleTextbox.Text = _editedStruct.Title;
            descriptionTextbox.Text = _editedStruct.Description;
            lengthNumericInput.Value = _editedStruct.Minutes;
        }

        private void save()
        {
            _editedStruct.Title = titleTextbox.Text;
            _editedStruct.Description = descriptionTextbox.Text;
            _editedStruct.Minutes = decimal.ToInt32(lengthNumericInput.Value);
        }

        private void saveAndCloseButton_Click(object sender, EventArgs e)
        {
            save();
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lengthButtonClick(object sender, EventArgs e)
        {
            int? selectedValue = ((Button)sender).Tag as int?;
            if (selectedValue == null)
                selectedValue = 0;
            lengthNumericInput.Value = (decimal)selectedValue;
        }

        private void MetadataEditorForm_Load(object sender, EventArgs e)
        {
            load();
        }

    }
}
