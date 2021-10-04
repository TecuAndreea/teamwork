var orderModalGrid = (function () {

    function _init() {
        $(document).on('click', function (e) {
            if (sessionStorage.getItem("rowClicked") == "true") {
                $.ajax({
                    type: "GET",
                    url: "/orderedProducts/" + sessionStorage.getItem("orderId"),
                    dataType: "json",
                    success: function (data) {
                        $("#orderedProductsTable").find("tbody tr").filter(".products").remove();
                        for (var item of data) {
                            var row = "<tr class='products'><td>" + item.item1 + "</td><td>" + item.item2 + "</td></tr>";
                            $("#orderedProductsTable > tbody").append(row);
                        }
                    }
                });
            }
        });

        $("#closeButton").on('click', function () {
            sessionStorage.setItem("rowClicked", false);
        });
    }

    return {
        init: _init
    };

})();

orderModalGrid.init();