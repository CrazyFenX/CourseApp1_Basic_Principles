using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // + - сложение     S += a     S = S + a
        // - - вычитание    S -= a     S = S - a
        // * - умножение    S *= a     S = S * a
        // / - деление      S /= a     S = S / a
        // % - остаток      S %= a     S = S % a

        //Посчитать сумму всех четных цифр числа
        private void startButton_Click(object sender, EventArgs e)
        {
            string inputStr = inputTextBox.Text;
            int inputNumber = Convert.ToInt32(inputStr);
            int sum = 0;
            //algorithm
            while (inputNumber > 0)
            {
                if ((inputNumber % 10) % 2 == 0){
                    sum += inputNumber % 10;
                }
                inputNumber = inputNumber / 10;
            }
            outputTextBox.Text = sum.ToString();
        }

        //Вывести на экран все числа между А и В, подсчитать их количество
        private void startButton2_Click(object sender, EventArgs e)
        {
            int A = Convert.ToInt32(inputATextBox.Text);
            int B = Convert.ToInt32(inputBTextBox.Text);

            int N = 0;
            string output = "";

            //"hello" + " " + "world" = "hello world"
            for(int i = A; i <= B; i++){
                output = output + i.ToString() + " ";
                N++;
            }
            output = output + $" Всего: {N}";

            outputTextBox2.Text = output;
        }

        //Домашка
//      Циклы
//          1)Вывести на экран квадраты чисел от А до В
//      Строки
//          2)Дан текст. Найти сумму имеющихся в нем цифр
//   ------------------------
//      Для тех, кому не хватило

//          1)Найти суму корней из чисел от 1 до Н
//          2)Найти суму кубов из чисел от A до B
//          3)Найти количество чисел не кратных Н на промежутке от А до В
//          4)Дан текст.Найдите наибольшее количество подряд идущих пробелов в нем

//      http://www.itmathrepetitor.ru/prog/zadachi-na-stroki/
//      http://codder.info/primery-resheniya-zadach-tsikl-for/
    }
}