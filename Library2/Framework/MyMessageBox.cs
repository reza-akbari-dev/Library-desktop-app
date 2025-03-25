namespace System
{
    public static class MyMessageBox
    {
        public static void SuccessMessage(string Msg = "mission accomplished")
        {
            MessageBox.Show(Msg, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void ValidationErrorMessage(string Msg = "Complete information is not entered")
        {
            MessageBox.Show(Msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void SelectionErrorMessage(string Msg = "Please select an item from the list")
        {
            MessageBox.Show(Msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static bool ConfirmedMessage()
        {
            var result = MessageBox.Show("Are you sure you want to apply the changes?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return false;
            }

            return true;
        }
    }
}
