// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$("#productJsGrid").jsGrid({
    width: "100%",
    height: "auto",

    heading: true,
    autoload: true,
    inserting: true,
    editing: true,
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

            $("<button>").attr({ class: "customGridDeletebutton jsgrid-button jsgrid-delete-button" })
                .click(function (e) {
                    alert("Title: ");
                    e.stopPropagation();
                });

            return $.ajax({
                type: "GET",
                url: "/products/" + sessionStorage.getItem("prod"),
                data: filter,
                dataType: "json"


            });
        },

        updateItem: function (updatingItem) {
            return $.ajax({
                type: "PUT",
                url: "/products",
                data: updatingItem
            });
        },

        insertItem: function (insertingItem) {
            return $.ajax({
                type: "POST",
                url: "/products/" + sessionStorage.getItem("prod"),
                data: insertingItem
            });
        }

    },

    fields: [
        {
            name: "productId",
            width: 50,
            title: "Id Produs",
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
            name: "price",
            width: 50,
            title: "Pret",
            type: "number",
            itemTemplate: function (value, item) {
                return "<div>" + value + "</div>"
            }
        },

        {
            name: "weight",
            width: 50,
            title: "Gramaj",
            type: "number",
            itemTemplate: function (value, item) {
                return "<div>" + value + "</div>"
            }
        },

        {
            name: "availableStock",
            width: 50,
            title: "Stoc disponibil",
            type: "number",
            itemTemplate: function (value, item) {
                return "<div>" + value + "</div>"
            }
        },

        {


            name: "photoUrl",
            width: 50,
            title: "Poza Produs",
            type: "text",
            itemTemplate: function (value, item) {
                var $photo = $("<div>").append($("<img width='100%' height='auto'>").attr("src", ".." + value.substring(1)));
                return $("<tr>").append($("<td>").append($photo));

            },

            insertTemplate: function () {

                var $result = jsGrid.fields.control.prototype.itemTemplate.apply(this, arguments);
                var $myButton = $("<input type='file' id='myFile' name='filename' accept='image/*'>Imagine</input>");
                return $result.add($myButton);
            }
        },


        {
            type: "control"
        }
    ]

});