$(document).ready(function() {
    $("#searchAuthor").keyup(function() {
        var name = $(this).val();
        $.ajax({
            type:'GET',
            url:'/Admin/SearchAuthor/',
            data: {name:name},
            success: function(data) {
                var html = "";
                $('tbody').html("");
                for(var i=0;i<data.length;i++) {
                    html += '<tr><td>'+data[i].idAuthor+'</td>';
                    html += '<td>'+data[i].nameAuthor+'</td>';
                    html += '<td><img src="../../images/'+data[i].imgAuthor+'" src="'+data[i].nameAuthor+'" width="78" height="92"></td>';
                    html += '<td><p class="content_DesAuthor">'+data[i].describeAuthor+'</p></td>';
                    html += '<td class="actionAdmin" style="width: 100px;"><a href="/Admin/DeleteAuthor/'+data[i].idAuthor+'" class="btnSubmit">';
                    html += '<i class="fa fa-trash"></i></a>|' ;
                    html += '<a href="../../Admin/EditAuthor/'+data[i].idAuthor+'"><i class="fa fa-edit"></i></a> </td> </tr>';  
                }
                $('tbody').append(html);
            }
        });
    });
    $("#searchCategory").keyup(function() {
        var name = $(this).val();
        $.ajax({
            type:'GET',
            url:'/Admin/SearchCategory/',
            data: {name:name},
            success: function(data) {
                var html = "";
                $('tbody').html("");
                for(var i=0;i<data.length;i++) {
                    html += '<tr><td>'+data[i].idCategory+'</td>';
                    html += '<td>'+data[i].nameCategory+'</td>';
                    html += '<td class="actionAdmin" style="width: 100px;"><a href="/Admin/DeleteCategory/'+data[i].idCategory+'" class="btnSubmit">';
                    html += '<i class="fa fa-trash"></i></a>|' ;
                    html += '<a href="../../Admin/EditCategory/'+data[i].idCategory+'"><i class="fa fa-edit"></i></a> </td> </tr>';  
                }
                $('tbody').append(html);
            }
        });
    });
    $("#searchSupplier").keyup(function() {
        var name = $(this).val();
        $.ajax({
            type:'GET',
            url:'/Admin/SearchSupplier/',
            data: {name:name},
            success: function(data) {
                var html = "";
                $('tbody').html("");
                for(var i=0;i<data.length;i++) {
                    html += '<tr><td>'+data[i].idSupplier+'</td>';
                    html += '<td>'+data[i].nameSupplier+'</td>';
                    html += '<td>'+data[i].addressSupplier+'</td>';
                    html += '<td>'+data[i].phoneSupplier+'</td>';
                    html += '<td class="actionAdmin" style="width: 100px;"><a href="/Admin/DeleteSupplier/'+data[i].idSupplier+'" class="btnSubmit">';
                    html += '<i class="fa fa-trash"></i></a>|' ;
                    html += '<a href="../../Admin/EditSupplier/'+data[i].idSupplier+'"><i class="fa fa-edit"></i></a> </td> </tr>';  
                }
                $('tbody').append(html);
            }
        });
    });
    $("#searchCustomer").keyup(function() {
        var name = $(this).val();
        $.ajax({
            type:'GET',
            url:'/Admin/SearchCustomer/',
            data: {name:name},
            success: function(data) {
                var html = "";
                $('tbody').html("");
                for(var i=0;i<data.length;i++) {
                    html += '<tr><td scope="row">'+data[i].idCustomer+'</td>';
                    html += '<td>'+data[i].nameCustomer+'</td>';
                    html += '<td>'+data[i].phoneCustomer+'</td> ';
                    html += '<td>'+data[i].country+'</td> ';
                    html += '<td>'+data[i].addressCustomer+'</td> ';
                    html += '<td>'+data[i].email+'</td> ';
                    html += '<td>'+data[i].password+'</td> ';
                    html += '<td class="actionAdmin" style="width: 100px;"><a href="/Admin/CustomerDelete/'+data[i].idCustomer+'" class="btnSubmit">';
                    html += '<i class="fa fa-trash"></i></a>|' ;
                    html += '<a href="/Admin/UpdateCustomer/'+data[i].idCustomer+'"><i class="fa fa-edit"></i></a> </td> </tr>';  
                }
                $('tbody').append(html);
            }
        });
    });
    $("#searchEmployee").keyup(function() {
        var name = $(this).val();
        $.ajax({
            type:'GET',
            url:'/Admin/SearchEmployee/',
            data: {name:name},
            success: function(data) {
                var html = "";
                $('tbody').html("");
                for(var i=0;i<data.length;i++) {
                    html += '<tr><td scope="row">'+data[i].idEmployee+'</td>';
                    html += '<td>'+data[i].nameEmployee+'</td>';
                    html += '<td>'+data[i].phoneEmployee+'</td> ';
                    html += '<td>'+data[i].addEmployee+'</td> ';
                    html += '<td>'+data[i].email+'</td> ';
                    html += '<td>'+data[i].password+'</td> ';
                    html += '<td class="actionAdmin" style="width: 100px;"><a href="/Admin/EmployeeDelete/'+data[i].idEmployee+'" class="btnSubmit">';
                    html += '<i class="fa fa-trash"></i></a>|' ;
                    html += '<a href="/Admin/UpdateEmployee/'+data[i].idEmployee+'"><i class="fa fa-edit"></i></a> </td> </tr>';  
                }
                $('tbody').append(html);
            }
        });
    });
    $("#searchDiscount").keyup(function() {
        var name = $(this).val();
        $.ajax({
            type:'GET',
            url:'/Admin/SearchDiscount/',
            data: {name:name},
            success: function(data) {
                var html = "";
                $('tbody').html("");
                html=data;
                $('tbody').append(html);
            }
        });
    });
    $("#searchBook").keyup(function() {
        var name = $(this).val();
        $.ajax({
            type:'GET',
            url:'/Admin/SearchBook/',
            data: {name:name},
            success: function(data) {
                var html = "";
                $('tbody').html("");
                html=data;
                $('tbody').append(html);
            }
        });
    });
});
//Invoice 
$(document).ready(function() {
    $(".Invoice").click(function() {
        var id = $(this).attr("data-id");
        var x = confirm("Are you sure you want to Invoice?");
        if(x) {
            $.ajax({
                type:'GET',
                url:'/Admin/CheckQuantity/',
                data:{id:id},
                success:function(data) {
                    if(data == "0") {
                        alert("Quantity Book not enough!");
                        location.reload();
                    } else {
                        window.location.href ="/Admin/GeneratePdf/"+id;
                    }
                }
            });
        } else return false;
    });
});
//Invoice Entry
$(document).ready(function() {
    $(".InvoiceEntry").click(function() {
        var id = $(this).attr("data-id");
        var x = confirm("Are you sure you want to Invoice?");
		if(x) {
            $.ajax({
                type:'GET',
                url:'/Admin/Index/',
                data: {id:id},
                success:function(data) {
                    window.location.href ="/Admin/GeneratePdfEntry/"+id;
                }
            });
        }
		else return false;
    });
});
//Create Entry
$(document).ready(function() {
    $(".btnAddEntry").click(function() {
        var name = $(".optionBook").val();
        var quantity = $(".quantity").val();
        var price = $(".priceBook").val();
        if(name != "" && quantity!="" && price!="") {
            if(quantity<0) {
                alert("Quantity Book must bigger 0!");
            } else if(price<0) {
                alert("Price Book must bigger 0!");
            } else {
                $.ajax({
                    type:'GET',
                    url:'/Admin/AddBookEntry/',
                    data:{name:name,quantity:quantity,price:price},
                    success: function(data) {
                        var html = "";
                        html += "<tr><td><input type='text' value='"+data.nameBook+"' name='name' class='border-0' disabled/></td>";
                        html += "<input type='hidden' value='"+data.idBook+"' name='id' />";
                        html += "<td><input type='text' value='"+data.amountBook+"' name='amount' class='w-100 border-0 quantityEntry'/></td>";
                        html += "<td><input type='text' value='"+data.priceBook+"'name='price' class='w-100 border-0 priceEntry'/></td>";
                        html += "<td align='center'><a class='xoaEntrybtn'><i class='fa fa-trash'></i></a></td></tr>";
                        $("tbody").append(html);
                    }
                });
            }
            
        } else if(quantity=="") {
            alert("Quantity not Empty!");
        } else if(name=="")
        {
            alert("Name Book not empty!");
        } else if(price == "") {
            alert("Price not empty!");
        }
    });
});
$(document).ready(function() {
    $(".xoaEntrybtn").click(function() {
        alert("huh");
        // $(this).parent().parent().remove();
    });
});