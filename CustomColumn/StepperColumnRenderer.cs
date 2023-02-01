using Syncfusion.Maui.DataGrid;

namespace DataGridMAUI
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
