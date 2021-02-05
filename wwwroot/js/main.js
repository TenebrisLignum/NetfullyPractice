function build() {
    var SummDok = document.getElementById('archive_table');
    SummSumm = "<tr>";

    if (document.getElementById('income').checked) {
        SummSumm += "<td style=\"color: green;\"><b>Дохід: <\/b><\/td>";
    } else if (document.getElementById('consumption').checked) {
        SummSumm += "<td style=\"color: red;\"><b>Витрати: <\/b><\/td>";
    }

    SummSumm += "<td><b>" + parseFloat(main_form.text.value) + " грн.<\/b><\/td><\/tr>"
    SummDok.insertAdjacentHTML("afterbegin", SummSumm);
}