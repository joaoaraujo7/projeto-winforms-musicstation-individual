using System.Reflection;

namespace MusicStationWinFormsApp.Helpers
{
    public static class DataGridHelpers
    {
        public static void ConfigurarPadrão(DataGridView dgv)
        {
            typeof(DataGridView).InvokeMember("DoubleBuffered",
                BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
                null, dgv, new object[] { true });

            dgv.AutoGenerateColumns = false;
            dgv.ReadOnly = true;
            dgv.Columns.Clear();

            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeColumns = true;
            dgv.AllowUserToResizeRows = false;
            dgv.RowHeadersVisible = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public static DataGridViewTextBoxColumn Texto(
            string name,
            string header,
            string property,
            DataGridViewAutoSizeColumnMode sizeMode = DataGridViewAutoSizeColumnMode.AllCells,
            int? width = null,
            float? fillWeight = null,
            DataGridViewContentAlignment? alignment = null,
            string? format = null)
        {
            var column = new DataGridViewTextBoxColumn
            {
                Name = name,
                HeaderText = header,
                DataPropertyName = property,
                AutoSizeMode = sizeMode
            };

            if (width.HasValue)
            {
                column.Width = width.Value;
            }

            if (fillWeight.HasValue)
            {
                column.FillWeight = fillWeight.Value;
            }

            if (alignment.HasValue)
            {
                column.DefaultCellStyle.Alignment = alignment.Value;
            }
            
            if (!string.IsNullOrWhiteSpace(format))
                column.DefaultCellStyle.Format = format;

            return column;
        }

        public static DataGridViewImageColumn Icone(
            string name,
            Image image,
            string tooltip,
            int width = 36)
        {
            return new DataGridViewImageColumn
            {
                Name = name,
                HeaderText = "",
                ToolTipText = tooltip,
                Image = image,
                Width = width,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                Resizable = DataGridViewTriState.False,
                DefaultCellStyle =
                {
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            };
        }
    }
}