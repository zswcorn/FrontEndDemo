$(document).ready(function () {
    $("#btTable").bootstrapTable({
        resizable: true,
        liveDrag: true,
        showExport: true,
        exportDataType: "basic",
        exportTypes: ['json', 'xml', 'csv', 'txt', 'sql', 'excel']
    });
});