

function confirmDelete(id, isDeleteClicked) {
    let deleteSpan = "deleteSpan_" + id;
    let confirmDeleteSpan = "confirmDeleteSpan_" + id;

    if (isDeleteClicked) {
        $("#" + deleteSpan).hide();
        $("#" + confirmDeleteSpan).show();
    } else {
        $("#" + deleteSpan).show();
        $("#" + confirmDeleteSpan).hide();
    }
}

$('.head').click(function(){
    $(this).toggleClass('active');
    $(this).parent().find('.arrow').toggleClass('arrow-animate');
    $(this).parent().find('.content').slideToggle(280);
  });

  $('.head2').click(function(){
    $(this).toggleClass('active2');
    $(this).parent().find('.arrow2').toggleClass('arrow-animate');
    $(this).parent().find('.content2').slideToggle(280);
  });
  // icon from Font Awesome was used in accordion-1

  function myFunction() {
    var x = document.getElementById("myDIV");
    if (x.style.display === "none") {
      x.style.display = "block";
    } else {
      x.style.display = "none";
    }
  }

  $(document).ready(function() {
  //   function populatePage(data){
  //     $("#xxx").html("XXX")
  // }
  // $.get("/track/comments/1",data=> {
  //     console.log(data)
  //     populatePage(data)
  // })

    // Get saved data from sessionStorage
    let selectedCollapse = sessionStorage.getItem('selectedCollapse');
    if(selectedCollapse != null) {
      $('.accordion .collapse').removeClass('show');
      $(selectedCollapse).addClass('show');
    }
    
    $('.accordion .reveal').on('click', function(){ 
      let target = $(this).data('target');
      //Save data to sessionStorage
      sessionStorage.setItem('selectedCollapse', target);
    });
  });

  $('#myform').submit(function() {
    $(this).find('input[type="text"]').each(function() {
        if($.trim($(this).val()) == '') $(this).val($(this).attr('placeholder'));
    });
});