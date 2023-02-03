using Syncfusion.Maui.DataGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataGridMAUI
{
    public class StepperColumn : DataGridColumn
    {
        public StepperColumn()
        {
            var cellType = typeof(DataGridColumn).GetRuntimeProperties().FirstOrDefault((property) => property.Name == "CellType");
            cellType.SetValue(this, "Stepper");
        }
    }
}
