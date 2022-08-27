//var cartItems = [];
$(function () {

    //Add product to Cart


    toastr.options = {
        "closeButton": true,
        "debug": false,
        "newestOnTop": false,
        "progressBar": true,
        "positionClass": "toast-top-right",
        "preventDuplicates": false,
        "onclick": null,
        "showDuration": "300",
        "hideDuration": "1000",
        "timeOut": "5000",
        "extendedTimeOut": "1000",
        "showEasing": "swing",
        "hideEasing": "linear",
        "showMethod": "fadeIn",
        "hideMethod": "fadeOut"
    }

        $("#btn-add-to-cart").click(function () {

            let productId = $("#btn-add-to-cart").attr("product-id");
            let productQuantity = parseInt($("#product-count").val());
            console.log(productQuantity);
            if (productQuantity > 0)
                addToCart(productId);
            else {
                let currentInput = $(this);
                currentInput.parent().find('input').val(1);
                showToasterMessage("zero or negative is not allowed as quantity ", "error");
            }
        });
        //end of click

        function addToCart(productId) {
            let numberOfProducts = parseInt($("#product-count").val());

            let cartObject = {
                ProductId: productId,
                Quantity: numberOfProducts
            }



            $.post("/Customer/Cart/Add",
                { model: cartObject },
                function (data) {
                    $("#stickyCart").effect("shake", { times: 4 }, 1000);
                    let storeItems = localStorage.getItem("cartItems");
                    let jsonData = JSON.parse(storeItems);
                    // console.log(jsonData.item1.length);
                    let checkExistence = false;
                    if (jsonData != null) {
                        jsonData.item1.forEach((item, index) => {
                            if (item.productId == productId)
                                checkExistence = true;
                        })
                    }
                    console.log(checkExistence);
                    if (!checkExistence) {
                        let productName = $("#product-name")[0].innerText;
                        let successToastMessage = productName + " Added to Cart!";
                        let cartCount = parseInt($("#cart-count").text());
                        if (jsonData != null)
                            $("#itemCountPara").text(jsonData.item1.length + 1 + " " + 'ITEMS');
                        else
                            $("#itemCountPara").text('1 ITEMS');
                        $("#cart-count").text(cartCount + 1);
                        showToasterMessage(successToastMessage, "success");
                    }

                    localStorage.setItem("cartItems", JSON.stringify(data));
                    storeItems = localStorage.getItem("cartItems");
                    jsonData = JSON.parse(storeItems);
                    const sum = jsonData.item2.reduce((a, b) => parseFloat(a) + parseFloat(b), 0);
                    $(".cartMoney").text(`৳ ${sum}`);

                }).fail(function (data) {
                    console.log(data);
                });
        }
        function showToasterMessage(message, type) {
            if (type == "success")
                toastr["success"](message);
            else
                toastr["error"](message);
        }
    });
