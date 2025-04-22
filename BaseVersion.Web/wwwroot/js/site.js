let deleteUrl = '';
let deleteId = 'delete-';

//add datatable
//dynamic data sort and filter
//two error show at complex tabstrip view 
//tiny mce for big input
$(document).ready(function () {

    //#region Global toaster 

    var message = getQueryParam('message');
    if (message) {

        toastr.success(decodeURIComponent(message));
        removeQueryParam('message');
    }
    var redirectUrl = "";
    function getQueryParam(param) {
        var urlParams = new URLSearchParams(window.location.search);
        return urlParams.get(param);
    }

    function removeQueryParam(param) {
        var url = window.location.href;
        var urlWithoutParam = url.split('?')[0];



        window.history.replaceState({}, document.title, urlWithoutParam);

    }

    window.history.pushState("", "", "/");

    
    $('form.complex-form').on('submit', function (event) {
        
        event.preventDefault();

        var $form = $(this);
        var url = $form.attr('action');
        var methodType = $form.attr('method');
        var data = $form.serialize();

        $.ajax({
            url: url,
            type: methodType,
            data: data,
            success: function (response) {
                if (response.success) {
                    var redirectUrl = response.redirectUrl + "?message=" + encodeURIComponent(response.message);
                    window.location.href = redirectUrl;
                } else {
                    if (response.isValidationError) {
                        TopAndFieldWiseErrorShow(response.errors);
                    }
                    toastr.warning(response.message);
                }
            },
            error: function (xhr, status, error) {
                toastr.error('An unexpected error occurred: ' + error);
            }
        });


    });

    // Handle form submission
    $('form:not(.complex-form)').on('submit', function (event) {

        event.preventDefault();

        var $form = $(this);
        var url = $form.attr('action');
        var methodType = $form.attr('method');
        var data = $form.serialize();

        var check = $(this).valid();
        if (check) {
            $(".validation-summary").text("");
            $.ajax({
                url: url,
                type: methodType,
                data: data,
                success: function (response) {
                    if (response.success) {
                        var redirectUrl = response.redirectUrl + "?message=" + encodeURIComponent(response.message);

                        window.location.href = redirectUrl;


                    } else {
                        toastr.warning(response.message);
                    }
                },
                error: function (xhr, status, error) {
                    toastr.error('An unexpected error occurred: ' + error);
                }
            });

        }
    });
    function TopAndFieldWiseErrorShow(errors) {
        $(".validation-summary").html("");
        $(".field-validation-error").html("");

        var finalMessage = "";
        $.each(errors, function (field, errorMessage) {
            finalMessage += errorMessage + "<br/>";

            var inputfiled = $(`[name='${field}']`);
            inputfiled.after(`<span class="text-danger field-validation-error" > ${errorMessage} </span>`);
        })
        $(".validation-summary").html(finalMessage);

    }


    $('.GlobalAjax').on('click', function (event) {
        
        event.preventDefault();

        var $link = $(this); // this refers to the <a> tag
        var url = $link.attr('href'); // Get the href attribute for the URL

        $.ajax({
            url: url,
            type: 'GET', // Anchor links usually use GET requests
            success: function (response) {
                if (response.success) {
                    var redirectUrl = response.redirectUrl + "?message=" + encodeURIComponent(response.message);
                    window.location.href = redirectUrl;

                } else {
                    toastr.warning(response.message);
                }
            },
            error: function (xhr, status, error) {
                toastr.error('An unexpected error occurred: ' + error);
            }
        });
    });


    // Handle delete button click

    $('.delete-button').on('click', function (event) {
        
        event.preventDefault();
        deleteUrl = $(this).attr('href'); // Store the URL for deletion
        $('#deleteConfirmationModal').modal('show'); // Show the modal
    });

    // Handle the confirmation button click
    $('#confirmDeleteButton').on('click', function () {
        $.ajax({
            url: deleteUrl,
            type: 'DELETE',
            success: function (response) {
                if (response.success) {
                    toastr.success(response.message);

                    // Optionally, remove the deleted row
                    //$('.delete-button[href="' + deleteUrl + '"]').closest('tr').remove();

                    //for url hide
                    $('.delete-button').closest('tr').remove();


                } else {
                    toastr.warning(response.message);
                }
            },
            error: function (xhr, status, error) {
                toastr.error('An unexpected error occurred: ' + error);
            }
        });
        $('#deleteConfirmationModal').modal('hide'); // Hide the modal after confirmation
    });


    //#endregion



});

function redirectToAction(area, controller, action, id) {
    
    // Build the dynamic URL
    const url = `/${area}/${controller}/${action}?id=${id}`;
    // Redirect to the URL
    window.location.href = url;
}

function redirectToDelete(area, controller, action, id) {
    
    deleteId += id;
    deleteUrl = `/${area}/${controller}/${action}?id=${id}`;
    $('#deleteConfirmationModal').modal('show');

}


