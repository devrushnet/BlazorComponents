# BlazorComponents
Blazor Components
  - Data Grid
  - Tab Control
  - Modal Control
  - Pager

## Usage
Donwload BlazorComponents.ClassLibrary and reference to your project, in the file _Imports.razor add the following @using 
- @using BlazorComponents.ClassLibrary.Components
- @using BlazorComponents.ClassLibrary.Components.Grid
- @using BlazorComponents.ClassLibrary.Components.Pager
- @using BlazorComponents.ClassLibrary.Components.Tab

###### Grid

    <Grid Items ="@forecasts" PageSize="3" HasEdit="true" HasDelete="true" OnDeleteRecord="OnDeleteRecord" OnEditRecord="OnEditRecord">
        <GridColumn TRowData="WeatherForecast" Expression="f => f.Date" Format="d"/>
        <GridColumn TRowData="WeatherForecast" Expression="f => f.TemperatureC"/>
        <GridColumn TRowData="WeatherForecast" Expression="f => f.TemperatureF"/>
        <GridColumn TRowData="WeatherForecast" Expression="f => f.Summary"/>
    </Grid>
    
    private void OnDeleteRecord(object item)
    {
        modal.Open();
    }

    private void OnEditRecord(object item)
    {
        
    }
}
