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
    invalidNotify: function (args) {
        $('#alert-error-not-submit').removeClass('hidden');
    },
    pageLoading: false,
    pageSize: 10,
    pageButtonCount: 5,
    pageIndex: 1,

    deleteConfirm: "Esti sigur ca vrei sa stergi acest producator?",

    rowClick: function (args) {
        console.log(args)
        var getData = args.item;     
        var text = [];
        
        text.push(getData["producerId"])
        var name = getData["name"];
        var name2 = name.replace(/ /g, '')
        sessionStorage.setItem("prod", text);
        sessionStorage.setItem("prodName", name2);
        $("#adaugareProdus").show();

        $("#label").text("Salut, " + getData["name"] + ' iti poti adauga alte produse la sectiunea "Adaugare produse".').css('font-weight','bold');

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
            name: "name",
            width: 50,
            title: "Nume",
            type: "text",

            validate: {
                message: function (value, item) {
                    return "Introduceti numele complet.";
                },
                validator: function (value, item) {
                    return /^([a-zA-Z]{2,}\s[a-zA-Z]{1,}'?-?[a-zA-Z]{2,}\s?([a-zA-Z]{1,})?)$/.test(value);
                }
            },

            itemTemplate: function (value, item) {
                return "<div>" + value + "</div>"
            }
        },
        {
            name: "phoneNumber",
            width: 50,
            title: "Numar telefon",
            type: "text",
            validate: "required",
            validate: {
                message: function (value, item) {
                    return "Indroduceti un numar valid de telefon.";
                },
                validator: function (value, item) {
                    return /^([0-9]{10})$/.test(value);
                }
            },
            itemTemplate: function (value, item) {
                return "<div>" + value + "</div>"
            }
        },

        {
            name: "deliveryCost",
            width: 50,
            title: "Cost livrare",
            type: "number",
            validate: {
                validator: "range",
                message: function (value, item) {
                    if(value!=undefined)
                        return "Alegeti costul livrarii intre 0 si 1000 lei. Ati introdus \"" + value + "\" dar este in afara intervalului.";
                    else
                    return "Alegeti costul livrarii intre 0 si 1000 lei.";
                },
                param: [0, 1000]
            },

            itemTemplate: function (value, item) {
                return "<div>" + value + "</div>"
            }
        },

        {
            name: "minimumOrder",
            width: 50,
            title: "Comanda minima",
            type: "number",
            validate: {
                validator: "range",
                message: function (value, item) {
                    if(value!=undefined)
                        return "Alegeti comanda minima intre 0 si 1000 lei. Ati introdus \"" + value + "\" dar este in afara intervalului.";
                    else
                    return "Alegeti comanda minima intre 0 si 1000 lei.";
                },
                param: [0, 1000]
            },

            itemTemplate: function (value, item) {
                return "<div>" + value + "</div>"
            }
        },
       

        {
            type: "control"
        }

        
    ]
});