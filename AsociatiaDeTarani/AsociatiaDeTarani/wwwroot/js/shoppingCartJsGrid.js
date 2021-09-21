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

    rowClick: function (args) {
        console.log(args)
        var getData = args.item;
        var text = [];
        text.push(getData["product"])
        sessionStorage.setItem("shoppingItemProduct", text);
    },

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
            title: "Product",
            sorting: false,
            filtering: false,
            itemTemplate: function (value, item) {
                return "<div style='color:blue'>" + value + "</div>"
            }
        },
        {
            name: "amount",
            width: 50,
            title: "Amount",
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
            type: "control"
        }
    ]
});