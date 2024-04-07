function tinhTongCacSoNguyenTo() {
  let a = document.getElementsByName("soa")[0];
  let b = document.getElementsByName("sob")[0];
  let result = document.getElementById("result");
  let flag;
  let sum = 0;
  let valueOfA = parseInt(a.value);
  let valueOfB = parseInt(b.value);
  if (valueOfA < valueOfB) {
    let output = "";
    let daySoNguyenTo = ""; 
    for (let i = valueOfA; i < valueOfB; i++) {
      flag = 1;
      for (let j = 2; j <= i / 2; j++) {
        if (i % j == 0) {
          flag = 0;
          break;
        }
      }
      if (flag == 1) {
        sum += i;
        output += i + " + ";
        daySoNguyenTo += i + ", "
      }
    }
    output = output.slice(0, -3);
    output += " = " + sum;
    result.innerHTML = "=>output = " + output +"<br>" + 
    `<h2>Các số nguyên tố từ khoảng ${valueOfA} đến ${valueOfB} là: ` + daySoNguyenTo.slice(0,-2) + "</h2><br>" +
    `<h2>Tổng các số nguyên tố trong khoảng là : ${sum}</h2>`;
  }
  if (valueOfA >= valueOfB) {
    result.innerHTML = "bạn phải nhập số a bé hơn số b";
  }
}
