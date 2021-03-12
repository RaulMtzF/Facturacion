$(document).ready(function () {

    $("#Prueba").click(function () {
        alert("Entro");
    });

    $("#grid").on("click", "td", function (e) {

        var row = $(this).closest("tr");
        var Id = row.find("td:first").text();

        
        InfoFactura(Id);
    });

    CragarGrid();
});

function CragarGrid() {
    var data = {
    };

    conectarAsy(UrlActual + "Facturacion/GetFacturas", data, function (result) {
        console.log(result);
        if (result != null) {

            $("#GifCargando").hide();
            $("#grid").show();

            grid(result.list);
        }

    });
}

function grid(data) {

    $("#grid").html('');
    var gridOrder = $("#grid").kendoGrid({
        //toolbar: ["excel", "pdf"],
        //toolbar: kendo.template($("#templateToolBar").html()),
        //excel: {
        //    fileName: "orders.xlsx",
        //    allPages: true
        //},
        //pdf: {
        //    fileName: "orders.pdf",
        //    allPages: true,
        //    avoidLinks: true,
        //    paperSize: "A4",
        //    margin: { top: "2cm", left: "1cm", right: "1cm", bottom: "1cm" },
        //    landscape: true,
        //    repeatHeaders: true,
        //    template: $("#page-template").html(),
        //    scale: 0.2
        //},
        dataSource: {
            data: {
                "items": data
            },
            pageSize: 10,
            schema: {
                data: "items",
                total: "items.length",
                model: {
                    fields: {
                        Id: { type: "string" },
                        Nombre: { type: "string" }
                    }
                }
            }
        },
        sortable: false,
        pageable: {
            refresh: false,
            pageSizes: false,
            //alwaysVisible: false
            //buttonCount: 10
        },
        reorderable: false,
        resizable: false,
        dataBound: function (e) {
            var grid = $("#grid").data("kendoGrid");
            var widthGrid = Number($("#grid").css("width").replace("px", ""));
            var widthColumns = 0;
            for (var i = 0; i < this.columns.length; i++) {
                if (i < grid.columns.length - 1) {
                    grid.autoFitColumn(i);
                    //grid.columns[8].width = 150;
                    widthColumns = widthColumns + grid.columns[i].width;

                } else if (widthGrid > widthColumns) {
                    grid.columns[i].width = ((widthGrid - widthColumns) + 150);
                } else {
                    this.autoFitColumn(i);
                }
            }
            var items = e.sender.items();
            items.each(function (e) {
                var ddt = $(this).find('.dropDownTemplate');

                //$(ddt).kendoDropDownList({
                //    value: 0,
                //    dataSource: ddlDataSource,
                //    dataTextField: "displayValue",
                //    dataValueField: "value",
                //    change: onDDLChange
                //    //select: onDDLSelect
                //});
            });    
        },
        columns: [
            {
                field: "Id",
                title: "Id"
            },
            {
                field: "Servicio",
                title: "Servicio",
                attributes: {
                    "class": "table-cell",
                    style: "text-align: left; font-size: 14px"
                }
            },
            {
                field: "Cliente",
                title: "Cliente",
                attributes: {
                    "class": "table-cell",
                    style: "text-align: left; font-size: 14px"
                }
            },
            {
                field: "RFC",
                title: "RFC"
            },
            {
                field: "Estatus",
                title: "Estatus"
            },
            {
                field: "NumeroFactura",
                title: "Número de factura"
            },
            {
                field: "FechaServicio",
                title: "Fecha de Servicio"
            },
            {
                field: "FechaTimbrado",
                title: "Fecha de Timbrado"
            },
            {
                field: "Enviado",
                title: "Enviado"
            },
            {
                field: "FechaEnvio",
                title: "Fecha de Envío"
            },
            {
                field: "CorreoEnvio",
                title: "Correo de Envío",
                attributes: {
                    "class": "table-cell",
                    style: "text-align: left; font-size: 14px"
                }
            }
        ]
    });

}

function InfoFactura(Id) {

    $("#InfoFactura").hide();
    $("#InfoAuditoria").hide();
    $("#GifInfoFac").show();

    var data = {
        Id: Id
    };

    conectarAsy(UrlActual + "Facturacion/InfoFactura", data, function (result) {
        
        if (result != null) {

            $("#GifInfoFac").hide();
            $("#InfoFactura").show();
            $("#InfoAuditoria").show();
        }

    });
}