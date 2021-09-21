$("#shoppingCartGrid").jsGrid({
    width: "100%",
    height: "auto",

    heading: true,
    autoload: true,
    autosearch: true,
    editing: true,
    invalidNotify: function (args) {
        $('#alert-error-not-submit').removeClass('hidden');
    },

    deleteConfirm: "Sigur stergeti toate produsele de acest fel din cos?",

    controller: {
        loadData: function (filter) {
            return $.ajax({
                type: "GET",
                url: "/shoppingCartItems",
                data: filter,
                dataType: "json"
            });
        },

        updateItem: function (updatingItem) {
            return $.ajax({
                type: "PUT",
                url: "/shoppingCartItems",
                data: updatingItem
            });
        },

        deleteItem: function (deletingItem) {
            return $.ajax({
                type: "DELETE",
                url: "/shoppingCartItems",
                data: deletingItem
            });
        },
    },

    fields: [
        {
            name: "product.name",
            width: 50,
            title: "Produs",
            sorting: false,
            filtering: false,
            itemTemplate: function (value, item) {
                return "<div style='color:green'>" + value + "</div>"
            }
        },
        {
            name: "amount",
            width: 50,
            title: "Cantitate",
            type: "number",
            itemTemplate: function (value, item) {
                return "<div>" + value + "</div>"
            },
            validate: {
                message: function (value, item) {
                    return "Introduceti numar mai mare ca 0";
                },
                validator: function (value, item) {
                    return value > 0;
                }
            },
        },

        {
            name: "price",
            title: "Pret",
            itemTemplate: function (value, item) {
                var currency = "";
                if (value == 1) {
                    currency = " leu";
                }
                else {
                    currency = " lei";
                }
                return "<div>" + value + currency + "</div>"
            },
        },

        {
            type: "control"
        }
    ]
});