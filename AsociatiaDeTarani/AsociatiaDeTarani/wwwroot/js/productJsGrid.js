﻿// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
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
    invalidNotify: function (args) {
        $('#alert-error-not-submit').removeClass('hidden');
    },
    autosearch: true,
    pageLoading: false,
    pageSize: 5,
    pageButtonCount: 5,
    pageIndex: 1,

    deleteConfirm: "Esti sigur ca vrei sa stergi acest produs?",


    controller: {
        loadData: function (filter) {


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
            validate: {
                message: function (value, item) {
                    return "Introduceti numele complet al produsului.";
                },
                validator: function (value, item) {
                    return /^([a-zA-Z ]{2,})$/.test(value);
                }
            },

            itemTemplate: function (value, item) {
                return "<div>" + value + "</div>"
            }
        },
        {
            name: "price",
            width: 50,
            title: "Pret",
            type: "number",
            validate: "required",
            validate: {
                validator: "range",
                message: function (value, item) {
                    if (value != undefined)
                        return "Alegeti pretul produsului /kg intre 0 si 1000 lei. Ati introdus \"" + value + "\" dar este in afara intervalului.";
                    else
                        return "Alegeti pretul produsului /kg intre 0 si 1000 lei.";
                },
                param: [0, 1000]
            },

            itemTemplate: function (value, item) {
                return "<div>" + value + "</div>"
            }
        },

        {
            name: "weight",
            width: 50,
            title: "Gramaj",
            type: "number",
            validate: {
                validator: "range",
                message: function (value, item) {
                    if (value != undefined)
                        return "Alegeti gramajul produsului in kg, intre 0 si 1000. Ati introdus \"" + value + "\" dar este in afara intervalului.";
                    else
                        return "Alegeti gramajul produsului in kg, intre 0 si 1000.";
                },
                param: [0, 1000]
            },
            itemTemplate: function (value, item) {
                return "<div>" + value + "</div>"
            }
        },

        {
            name: "availableStock",
            width: 50,
            title: "Stoc disponibil",
            type: "number",
            validate: {
                validator: "range",
                message: function (value, item) {
                    if (value != undefined)
                        return "Alegeti stocul disponibil al produsului in kg, intre 0 si 100000 . Ati introdus \"" + value + "\" dar este in afara intervalului.";
                    else
                        return "Alegeti stocul disponibil al produsului in kg, intre 0 si 100000.";
                },
                param: [0, 100000]
            },
            itemTemplate: function (value, item) {
                return "<div>" + value + "</div>"
            }
        },

        {


            name: "photoUrl",
            width: 50,
            title: "Poza Produs",
            editing: false,

            itemTemplate: function (value, item) {
                var $photo = $("<div>").append($("<img width='100%' height='auto'>").attr("src", "../" + value.substring(1)));
                return $("<tr>").append($("<td>").append($photo));

            },

            insertTemplate: function () {

                var $result = jsGrid.fields.control.prototype.itemTemplate.apply(this, arguments);
                var $myButton = $("<input type='file' id='myFile' name='filename' accept='image/*'>Imagine</input>");
                this.photoUrl = "1";
                return $result.add($myButton);
            }
        },


        {
            type: "control"
        }
    ]

});