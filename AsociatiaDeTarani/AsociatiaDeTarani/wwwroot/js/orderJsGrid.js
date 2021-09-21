// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$("#orderJsGrid").jsGrid({
    width: "100%",
    height: "auto",

    heading: true,
    autoload: true,
    inserting: true,
    sorting: true,
    selecting: true,
    paging: true,
    autosearch: true,
    pageLoading: false,
    pageSize: 5,
    pageButtonCount: 5,
    pageIndex: 1,

    deleteConfirm: "Are you sure you want to delete the item?",


    controller: {
        loadData: function (filter) {
            return $.ajax({
                type: "GET",
                url: "/orders",
                data: filter,
                dataType: "json"
            });
        },

        insertItem: function (insertingItem) {
            return $.ajax({
                type: "POST",
                url: "/orders",
                data: insertingItem
            });
        }

    },

    fields: [
        {
            name: "orderId",
            width: 50,
            title: "Id Comanda",
            sorting: false,
            filtering: false,
            itemTemplate: function (value, item) {
                return "<div style='color:blue'>" + value + "</div>"
            }
        },
        {
            name: "clientId",
            width: 50,
            title: "Id Client",
            type: "number",
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
                return "<div>" + value + "</div>"
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
        },

        {
            type: "control"
        }
    ]

});