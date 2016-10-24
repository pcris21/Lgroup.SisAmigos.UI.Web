
$("#Telefone").mask("(99) 99999-9999");
$("#DataNascimento").mask("99/99/9999");
$("#DataNascimento").datepicker({
    dateFormat: 'dd/mm/yy',
    changeYear: true,
    changeMonth: true,
    yearRange: "1920:*",
    dayNamesMin: ["Dom", "Seg", "Ter", "Qua", "Qui", "Sex", "Sab"],
    monthNamesShort: ["Jan", "Fev", "Mar", "Abr", "Mai", "Jun", "Jul", "Ago", "Set", "Nov", "Out", "Dez"]

});