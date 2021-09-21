$("#shoppingCartGrid").jsGrid({
    width: "100%",
    height: "auto",

    heading: true,
    autoload: true,
    autosearch: true,

    deleteConfirm: "Confirmare stergere produs din cos",

    controller: {
        loadData: function (filter) {
            return $.ajax({
                type: "GET",
                url: "/shoppingCartItems",
                data: filter,
                dataType: "json"
            });
        }
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
            }
        },

        {
            type: "control"
        }
    ]
});