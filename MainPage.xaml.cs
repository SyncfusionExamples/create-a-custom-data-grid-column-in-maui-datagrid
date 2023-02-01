
using Syncfusion.Maui.DataGrid;

namespace DataGridMAUI;

public partial class MainPage : ContentPage
{
    public SfDataGrid dataGrid;
    EmployeeViewModel viewModel;
    public MainPage()
	{
		InitializeComponent();
        dataGrid = new SfDataGrid() { ColumnWidthMode = ColumnWidthMode.Auto };
        viewModel = new EmployeeViewModel();
        dataGrid.ItemsSource = viewModel.Employees;
        dataGrid.AutoGenerateColumnsMode = AutoGenerateColumnsMode.None;
        dataGrid.CellRenderers.Add("Stepper", new StepperColumnRenderer());
        var customColumn = new StepperColumn();
        customColumn.MappingName = "OrderID";
        dataGrid.Columns.Add(customColumn);
        this.Content = dataGrid;
    }	
}

