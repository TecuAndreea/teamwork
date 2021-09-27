// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$("#orderJsGrid").jsGrid({
    width: "100%",
    height: "auto",

    heading: true,
    autoload: true,
    inserting: false,
    sorting: true,
    selecting: true,
    paging: true,
    autosearch: true,
    pageLoading: false,
    pagerContainer: null,
    pageIndex: 1,
    pageSize: 10,
    pagerFormat: "Pagina: {first} {prev} {pages} {next} {last} {pageIndex} din {pageCount}",
    pagePrevText: "Inapoi",
    pageNextText: "Inainte",
    pageFirstText: "Prima",
    pageLastText: "Ultima",

    controller: {
        loadData: function (filter) {
            return $.ajax({
                type: "GET",
                url: "/ordersAndClientName",
                data: filter,
                dataType: "json"
            });
        },
    },

    fields: [
        {
            name: "orderId",
            width: 50,
            title: "Nr. Comanda",
            sorting: false,
            filtering: false,
            itemTemplate: function (value, item) {
                return "<div style='color: blue;'><b>" + "CO000" + value + "</b></div>"
            }
        },
        {
            name: "clientName",
            width: 50,
            title: "Nume Client",
            type: "text",
            itemTemplate: function (value, item) {
                return "<div>" + value + "</div>"
            }
        },
        {
            name: "placementDate",
            width: 50,
            title: "Data plasarii",
            type: "text",
            itemTemplate: function (value, item) {
                var options = { weekday: 'long', year: 'numeric', month: 'long', day: 'numeric' };
                return "<div>" + new Date(value).toLocaleDateString('ro-RO', options) + "</div>";
            }
        },
        {
            name: "placementDate",
            width: 50,
            title: "Ora plasarii",
            type: "text",
            itemTemplate: function (value, item) {
                return "</div>" + new Date(value).toTimeString() + "</div>";
            }
        },
        {
            name: "totalPrice",
            width: 50,
            title: "Pret total",
            type: "number",
            itemTemplate: function (value, item) {
                return "<div>" + value + "</div>"
            }
        }
    ]

});