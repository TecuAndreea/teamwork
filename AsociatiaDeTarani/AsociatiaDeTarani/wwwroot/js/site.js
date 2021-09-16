// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$("#jsGrid2").jsGrid({
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

    rowClick: function (args) {
        console.log(args)
        var getData = args.item;     
        var text = [];
        text.push(getData["producerId"])
        sessionStorage.setItem("prod", text);

            

       

        $("#label").text("Ati selectat producatorul cu numele:" + getData["name"])
    },

    controller: {
        loadData: function (filter) {
            return $.ajax({
                type: "GET",
                url: "/producers",
                data: filter,
                dataType: "json"
            });
        },

        insertItem: function (insertingItem) {
            return $.ajax({
                type: "POST",
                url: "/producers",
                data: insertingItem
            });
        }

    },

    fields: [
        {
            name: "producerId",
            width: 50,
            title: "Id Producator",
            sorting: false,
            filtering: false,
            itemTemplate: function (value, item) {
                return "<div style='color:blue'>" + value + "</div>"
            }
        },
        {
            name: "name",
            width: 50,
            title: "Nume",
            type: "text",
            itemTemplate: function (value, item) {
                return "<div>" + value + "</div>"
            }
        },
        {
            name: "phoneNumber",
            width: 50,
            title: "Numar telefon",
            type: "text",
            itemTemplate: function (value, item) {
                return "<div>" + value + "</div>"
            }
        },

        {
            name: "deliveryCost",
            width: 50,
            title: "Cost livrare",
            type: "number",
            itemTemplate: function (value, item) {
                return "<div>" + value + "</div>"
            }
        },

        {
            name: "minimumOrder",
            width: 50,
            title: "Comanda minima",
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