
using Syncfusion.Maui.DataGrid;

namespace DataGridMAUI;

public partial class MainPage : ContentPage
{
    EmployeeViewModel viewModel;
    public MainPage()
	{
		InitializeComponent();
        dataGrid.CellRenderers.Add("Stepper", new StepperColumnRenderer());
    }	
}

