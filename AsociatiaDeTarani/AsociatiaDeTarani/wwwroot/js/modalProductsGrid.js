var orderModalGrid = (function () {

    function _init() {
        $("#orderModalGrid").jsGrid({
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
                    var vaaar = sessionStorage.getItem("orderId");
                    console.log("in modal" + vaaar);
                    return $.ajax({
                        type: "GET",
                        url: "/orderedProducts/" + vaaar,
                        data: filter,
                        dataType: "json"
                    });
                },
            },

            fields: [
                {
                    name: "item1",
                    width: 50,
                    title: "Nume Produs",
                    itemTemplate: function (value, item) {
                        return "<div>" + value + "</div>"
                    }
                },
                {
                    name: "item2",
                    width: 50,
                    title: "Cantitate",
                    itemTemplate: function (value, item) {
                        return "<div>" + value + "</div>"
                    }
                }
            ]

        });
    }


    return {
        init: _init
    };

})();
orderModalGrid.init();


