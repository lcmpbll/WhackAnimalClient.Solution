// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
// import $ from 'jquery';
// import 'bootstrap';
// import '~/css/site.css';

function clearFields() {
  $("#answer").val();
  $(".correct").hide();
  $(".incorrect").hide();
}

$("#submit").click(function() {

  let answer = $("#answer").val();
  let input = $("#input").val();
  console.log(input);
  console.log(answer);
  if (answer.includes(input)) {
  
    $(".correct").show();
    $("incorrect").hide();
  }
  else {
    $(".incorrect").show();
  }
  
  
})