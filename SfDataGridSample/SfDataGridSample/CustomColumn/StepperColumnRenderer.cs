using Syncfusion.Maui.DataGrid;

namespace SfDataGridSample
{
public class StepperColumnRenderer : DataGridCellRenderer<Stepper, Stepper>
{
    public StepperColumnRenderer()
    {
    }

    protected override Stepper OnCreateDisplayUIView()
    {
        return new Stepper();
    }

}
}
