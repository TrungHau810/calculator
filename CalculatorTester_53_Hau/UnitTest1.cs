using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Caculation_53_Hau;

namespace CalculatorTest_53_Hau
{
    [TestClass]
    public class UnitTest1
    {
        public TestContext TestContext { get; set; }

        private Calculation_53_Hau c_53_Hau;    //Class Calcution_53_Hau phải là public
        [TestInitialize]
        // Set up dữ liệu dùng chung cho các TC
        public void SetValue_53_Hau()
        {
            c_53_Hau = new Calculation_53_Hau(12, 2);   //Cho 2 giá trị mặc định a = 12 và b = 2
        }

        [TestMethod]
        //Viết TC1: Phép cộng, nhận 2 số a = 12, b = 2 => Kết quả = 14
        public void TC1_53_Hau_Cong()
        {
            int expected_53_Hau, actual_53_Hau;
            expected_53_Hau = 14;   //Gán expected là 14 (12 + 2 = 14) -> Kết quả mong muốn
            actual_53_Hau = c_53_Hau.Execute_53_Hau("+");  //Kết quả nhận được
            Assert.AreEqual(expected_53_Hau, actual_53_Hau);
        }

        [TestMethod]
        //Viết TC2: Phép trừ, nhận 2 số a = 12, b = 2 => Kết quả = 10
        public void TC2_53_Hau_Tru()
        {
            int expected_53_Hau, actual_53_Hau;
            expected_53_Hau = 10;   //Gán expected là 10 (12 - 2 = 10) -> Kết quả mong muốn
            actual_53_Hau = c_53_Hau.Execute_53_Hau("-");  //Kết quả nhận được
            Assert.AreEqual(expected_53_Hau, actual_53_Hau);
        }

        [TestMethod]
        //Viết TC3: Phép nhân, nhận 2 số a = 12, b = 2 => Kết quả = 24
        public void TC3_53_Hau_Nhan()
        {
            int expected_53_Hau, actual_53_Hau;
            expected_53_Hau = 24;   //Gán expected là 24 (12 * 2 = 24) -> Kết quả mong muốn
            actual_53_Hau = c_53_Hau.Execute_53_Hau("*");  //Kết quả nhận được
            Assert.AreEqual(expected_53_Hau, actual_53_Hau);
        }

        //Viết TC4: Phép chia 0
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TC4_53_Hau_Chia_0()   
        {
            //int expected_53_Hau, actual_53_Hau;
            c_53_Hau = new Calculation_53_Hau(10, 0);
            c_53_Hau.Execute_53_Hau("/");
        }

        //Viết TC5: Phép chia, nhận 2 số a = 12, b = 2 => Kết quả = 6
        [TestMethod]
        public void TC5_53_Hau_Chia()
        {
            int expected_53_Hau, actual_53_Hau;
            expected_53_Hau = 6;
            actual_53_Hau =  c_53_Hau.Execute_53_Hau("/");
            Assert.AreEqual(expected_53_Hau, actual_53_Hau);

        }

        //Các TC ra Fail
        [TestMethod]
        //Viết TC6: Phép cộng, nhận 2 số a = 12, b = 2 => Kết quả = 14
        public void TC6_53_Hau_Cong_Fail()
        {
            int expected_53_Hau, actual_53_Hau;
            expected_53_Hau = 10;   //Gán expected là 14 (12 + 2 = 14) -> Kết quả mong muốn
            actual_53_Hau = c_53_Hau.Execute_53_Hau("+");  //Kết quả nhận được
            Assert.AreEqual(expected_53_Hau, actual_53_Hau);
        }

        [TestMethod]
        //Viết TC7: Phép trừ, nhận 2 số a = 12, b = 2
        public void TC7_53_Hau_Tru_Fail()
        {
            int expected_53_Hau, actual_53_Hau;
            expected_53_Hau = 17;   //Gán expected để Fail
            actual_53_Hau = c_53_Hau.Execute_53_Hau("-");  //Kết quả nhận được
            Assert.AreEqual(expected_53_Hau, actual_53_Hau);
        }

        [TestMethod]
        //Viết TC8: Phép nhân, nhận 2 số a = 12, b = 2
        public void TC8_53_Hau_Nhan_Fail()
        {
            int expected_53_Hau, actual_53_Hau;
            expected_53_Hau = 23;   //Gán expected để Fail
            actual_53_Hau = c_53_Hau.Execute_53_Hau("*");  //Kết quả nhận được
            Assert.AreEqual(expected_53_Hau, actual_53_Hau);
        }

        //Viết TC9: Phép chia, nhận 2 số a = 12, b = 2 => Kết quả = 24
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TC9_53_Hau_Chia_Fail()
        {
            int expected_53_Hau, actual_53_Hau;
            expected_53_Hau = 5;
            actual_53_Hau = c_53_Hau.Execute_53_Hau("/");
            Assert.AreEqual(expected_53_Hau, actual_53_Hau);

        }

        //Đọc file csv 3 cột
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", 
            @".\Data_53_Hau\DataTest_53_Hau.csv", "DataTest_53_Hau#csv", 
            DataAccessMethod.Sequential)]
        //Testcase10: Phép cộng - 4 Pass
        [TestMethod]
        public void TC10_53_Hau_TestWithDataSource_4Pass()
        {
            int a_53_Hau = int.Parse(TestContext.DataRow[0].ToString());    //Đọc giá trị a (cột 1)
            int b_53_Hau = int.Parse(TestContext.DataRow[1].ToString());    //Đọc giá trị b (cột 2)
            int expected_53_Hau = int.Parse(TestContext.DataRow[2].ToString());     //Đọc kết quả mong muốn (cột 3)

            Calculation_53_Hau cal_53_Hau = new Calculation_53_Hau(a_53_Hau, b_53_Hau);
            int actual_53_Hau = cal_53_Hau.Execute_53_Hau("+"); //Mặc định phép cộng
            Assert.AreEqual(expected_53_Hau, actual_53_Hau);
        }


        //Đọc file csv 4 cột - file DataTest_53_Hau_4Cols
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @".\Data_53_Hau\DataTest_53_Hau_4Cols.csv", "DataTest_53_Hau_4Cols#csv",
            DataAccessMethod.Sequential)]

        //Testcase11:Đọc file csv - 4 phép tính
        [TestMethod]
        public void TC11_53_Hau_TestWithDataSource_4Cols_4Pass()
        {
            int a_53_Hau = int.Parse(TestContext.DataRow[0].ToString());    //Lấy số a
            int b_53_Hau = int.Parse(TestContext.DataRow[1].ToString());    //Lấy số b
            string calSymbol_53_Hau = TestContext.DataRow[2].ToString();    //Lấy dấu phép tính
            calSymbol_53_Hau = calSymbol_53_Hau.Replace("'", "");           //Bỏ kí tự ' trong calSymbol
            int expected_53_Hau = int.Parse(TestContext.DataRow[3].ToString()); //Lấy giá trị mong muốn

            Calculation_53_Hau cal_53_Hau = new Calculation_53_Hau(a_53_Hau, b_53_Hau);
            int actual_53_Hau = cal_53_Hau.Execute_53_Hau(calSymbol_53_Hau);    //Tính toán 
            Assert.AreEqual(expected_53_Hau, actual_53_Hau);
        }


    }
}
