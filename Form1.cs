using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RestaurantForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }     

            // Создаём общий класс для всех основных кнопок
        public void mainButtons(object sender, EventArgs e)
        {

            SalesCollection sales = new SalesCollection();

            EmployeesCollection employee = new EmployeesCollection();

            int rent = 250000;
            int taxes = 100000;

            System.Windows.Forms.Button button = (System.Windows.Forms.Button)sender;

            switch (button.Text)
            {
                case "За последний месяц":

                        // Очищаем поля от возможного заполнения 
                    totalEarningsBox.Items.Clear();
                    cleanEarningsBox.Items.Clear();
                    ordersTotalBox.Items.Clear();
                    employeesListBox.Items.Clear();
                    positionListBox.Items.Clear();
                    salaryListBox.Items.Clear();
                    popularOrderBox.Items.Clear();
                    rareOrderBox.Items.Clear();
                    ProfitabilityChart.Series["Profitability"].Points.Clear();
                    PopularityChart.Series["Popularity"].Points.Clear();
                    ExpensesChart.Series["Expenses"].Points.Clear();
                    SalaryBox.Items.Clear();
                    startMonthBox.Text = "";
                    endMonthBox.Text = "";

                        // Найдём последний месяц
                    var LastMonth = sales.array.Max(Sales => Sales.monthNum);
                    var salesLastMonth = sales.array.Where(Sales => Sales.monthNum == LastMonth);

                        // Определяем и выводим сколько всего заработал ресторан за последний месяц
                    var SalesTotalSum = salesLastMonth.Sum(Sales => Sales.totalEarned);
                    totalEarningsBox.Items.Add(SalesTotalSum + " ₽".ToString());

                        // Находим сумму всех зарплат сотрудников
                    var MonthSalariesSum = employee.array.Sum(Employee => Employee.Salary);

                        // Выводим в строку "Аренда" сумму оплаты аренды за последний месяц
                    rentBox.Text = (rent + " ₽");

                        // Выводим в строку "Производственные расходы" сумму расходов за последний месяц
                    productionPurchasesBox.Text = ((SalesTotalSum / 100 * 75) + " ₽").ToString();

                        // Выводим в строку "Налоги" сумму налога за последний месяц
                    taxesBox.Text = (((SalesTotalSum / 100 * 13) + taxes) + " ₽").ToString();

                    SalaryBox.Items.Add(MonthSalariesSum + " ₽");

                        // Выводим данные в строку "Чистая прибыль ресторана"
                    cleanEarningsBox.Items.Add(SalesTotalSum - rent - (SalesTotalSum / 100 * 75) - ((SalesTotalSum / 100 * 13) + taxes) - MonthSalariesSum + " ₽").ToString();

                        // Выводим на экран список сотрудников, их должности и зарплаты                    
                    foreach (Employee employees in employee.array)
                    {
                        employeesListBox.Items.Add(employees.firstName + " " + employees.lastName);
                        positionListBox.Items.Add(employees.Position);
                        salaryListBox.Items.Add(employees.Salary);
                    }

                        // Находим и выводим общее количество заказанных блюд
                    var TotalOrdersSum = salesLastMonth.Sum(Sales => Sales.quantity);
                    ordersTotalBox.Items.Add(TotalOrdersSum + " Блюд".ToString());

                        // Находим и выводим название самого популярного блюда
                    var OrderMax = salesLastMonth.Max(Sales => Sales.quantity);
                    var MostPopularOrder = salesLastMonth.Where(Sales => Sales.quantity == OrderMax);
                    foreach (Sales sale in MostPopularOrder)
                    {
                        popularOrderBox.Items.Add(sale.dishName);
                    }

                        // Находим и выводим название самого не популярного блюда
                    var OrderMin = salesLastMonth.Min(Sales => Sales.quantity);
                    var RareOrder = salesLastMonth.Where(Sales => Sales.quantity == OrderMin);
                    foreach (Sales sale in RareOrder)
                    {
                        rareOrderBox.Items.Add(sale.dishName);
                    }

                        // Заполняем графики прибыли и популярности соответсвующими значениями
                    foreach (Sales sale in salesLastMonth)
                    {
                        ProfitabilityChart.Series["Profitability"].Points.AddXY(sale.dishName, sale.totalEarned);
                        PopularityChart.Series["Popularity"].Points.AddXY(sale.dishName, sale.quantity);
                    }

                        // ЗАполняем график распределиения прибыли
                    ExpensesChart.Series["Expenses"].Points.AddXY("Налоги", (SalesTotalSum / 100 * 13) + taxes);
                    ExpensesChart.Series["Expenses"].Points.AddXY("Производство", SalesTotalSum / 100 * 75);
                    ExpensesChart.Series["Expenses"].Points.AddXY("Аренда", rent);
                    ExpensesChart.Series["Expenses"].Points.AddXY("Выплаты зарплат", MonthSalariesSum);
                    ExpensesChart.Series["Expenses"].Points.AddXY("Сверхприбыль", SalesTotalSum - rent - (SalesTotalSum / 100 * 75) - ((SalesTotalSum / 100 * 13) + taxes) - MonthSalariesSum);

                    break;

                case "За год":

                        // Очищаем поля от возможного заполнения 
                    totalEarningsBox.Items.Clear();
                    cleanEarningsBox.Items.Clear();
                    ordersTotalBox.Items.Clear();
                    employeesListBox.Items.Clear();
                    positionListBox.Items.Clear();
                    salaryListBox.Items.Clear();
                    popularOrderBox.Items.Clear();
                    rareOrderBox.Items.Clear();
                    ProfitabilityChart.Series["Profitability"].Points.Clear();
                    PopularityChart.Series["Popularity"].Points.Clear();
                    ExpensesChart.Series["Expenses"].Points.Clear();
                    SalaryBox.Items.Clear();
                    startMonthBox.Text = "";
                    endMonthBox.Text = "";

                        // Находим месяц от которого будет вестись подсчёты
                    var LastMonthInYear = sales.array.Max(Sales => Sales.monthNum);
                    var LastYear = sales.array.Where(Sales => Sales.monthNum > LastMonthInYear - 12);

                        // Определяем и выводим сколько всего заработал ресторан за год
                    var SalesTotalSumYear = LastYear.Sum(Sales => Sales.totalEarned);
                    totalEarningsBox.Items.Add(SalesTotalSumYear + " ₽".ToString());

                        // Находим сумму всех зарплат сотрудников
                    var MonthSalariesSumYear = employee.array.Sum(Employee => Employee.Salary);

                        // Выводим в строку "Аренда" сумму оплаты аренды за год
                    rentBox.Text = (rent * 12 + " ₽");

                        // Выводим в строку "Производственные расходы" сумму расходов год
                    productionPurchasesBox.Text = ((SalesTotalSumYear / 100 * 75) + " ₽").ToString();

                        // Выводим в строку "Налоги" сумму налога за год
                    taxesBox.Text = (((SalesTotalSumYear / 100 * 13) + taxes * 12) + " ₽").ToString();

                    SalaryBox.Items.Add((MonthSalariesSumYear * 12) + " ₽");

                        // Выводим данные в строку "Чистая прибыль ресторана"
                    cleanEarningsBox.Items.Add(SalesTotalSumYear - (rent * 12) - (SalesTotalSumYear / 100 * 75) -
                                              ((SalesTotalSumYear / 100 * 13) + taxes * 12) - (MonthSalariesSumYear * 12) + " ₽").ToString();

                        // Выводим на экран список сотрудников, их должности и зарплаты за год                   
                    foreach (Employee employees in employee.array)
                    {
                        employeesListBox.Items.Add(employees.firstName + " " + employees.lastName);
                        positionListBox.Items.Add(employees.Position);
                        salaryListBox.Items.Add(employees.Salary * 12);
                    }

                        // Находим и выводим общее количество заказанных блюд за год
                    var TotalOrdersSumYear = LastYear.Sum(Sales => Sales.quantity);
                    ordersTotalBox.Items.Add(TotalOrdersSumYear + " Блюд".ToString());

                        // Находим и выводим название самого популярного блюда за год
                    var OrderMaxYear = LastYear.Max(Sales => Sales.quantity);
                    var MostPopularOrderYear = LastYear.Where(Sales => Sales.quantity == OrderMaxYear);
                    foreach (Sales sale in MostPopularOrderYear)
                    {
                        popularOrderBox.Items.Add(sale.dishName);
                    }

                        // Находим и выводим название самого не популярного блюда за год
                    var OrderMinYear = LastYear.Min(Sales => Sales.quantity);
                    var RareOrderYear = LastYear.Where(Sales => Sales.quantity == OrderMinYear);
                    foreach (Sales sale in RareOrderYear)
                    {
                        rareOrderBox.Items.Add(sale.dishName);
                    }

                        // Заполняем графики прибыли блюд за год
                    ProfitabilityChart.Series["Profitability"].Points.AddXY("Kalakeitto", LastYear.Where(Sales => Sales.dishName == "Kalakeitto").Sum(Sales => Sales.totalEarned));
                    ProfitabilityChart.Series["Profitability"].Points.AddXY("Hernekeitto", LastYear.Where(Sales => Sales.dishName == "Hernekeitto").Sum(Sales => Sales.totalEarned));
                    ProfitabilityChart.Series["Profitability"].Points.AddXY("Leipäjuusto", LastYear.Where(Sales => Sales.dishName == "Leipäjuusto").Sum(Sales => Sales.totalEarned));
                    ProfitabilityChart.Series["Profitability"].Points.AddXY("Graavilohi", LastYear.Where(Sales => Sales.dishName == "Graavilohi").Sum(Sales => Sales.totalEarned));
                    ProfitabilityChart.Series["Profitability"].Points.AddXY("Kalakukko", LastYear.Where(Sales => Sales.dishName == "Kalakukko").Sum(Sales => Sales.totalEarned));
                    ProfitabilityChart.Series["Profitability"].Points.AddXY("Sahti", LastYear.Where(Sales => Sales.dishName == "Sahti").Sum(Sales => Sales.totalEarned));
                    ProfitabilityChart.Series["Profitability"].Points.AddXY("Minttu", LastYear.Where(Sales => Sales.dishName == "Minttu").Sum(Sales => Sales.totalEarned));

                        // Заполняем график популярности блюд за год
                    PopularityChart.Series["Popularity"].Points.AddXY("Kalakeitto", LastYear.Where(Sales => Sales.dishName == "Kalakeitto").Sum(Sales => Sales.quantity));
                    PopularityChart.Series["Popularity"].Points.AddXY("Hernekeitto", LastYear.Where(Sales => Sales.dishName == "Hernekeitto").Sum(Sales => Sales.quantity));
                    PopularityChart.Series["Popularity"].Points.AddXY("Leipäjuusto", LastYear.Where(Sales => Sales.dishName == "Leipäjuusto").Sum(Sales => Sales.quantity));
                    PopularityChart.Series["Popularity"].Points.AddXY("Graavilohi", LastYear.Where(Sales => Sales.dishName == "Graavilohi").Sum(Sales => Sales.quantity));
                    PopularityChart.Series["Popularity"].Points.AddXY("Kalakukko", LastYear.Where(Sales => Sales.dishName == "Kalakukko").Sum(Sales => Sales.quantity));
                    PopularityChart.Series["Popularity"].Points.AddXY("Sahti", LastYear.Where(Sales => Sales.dishName == "Sahti").Sum(Sales => Sales.quantity));
                    PopularityChart.Series["Popularity"].Points.AddXY("Minttu", LastYear.Where(Sales => Sales.dishName == "Minttu").Sum(Sales => Sales.quantity));

                        // Заполняем график распределиения прибыли за год
                    ExpensesChart.Series["Expenses"].Points.AddXY("Налоги", (SalesTotalSumYear / 100 * 13) + taxes * 12);
                    ExpensesChart.Series["Expenses"].Points.AddXY("Производство", (SalesTotalSumYear / 100 * 75));
                    ExpensesChart.Series["Expenses"].Points.AddXY("Аренда", (rent * 12));
                    ExpensesChart.Series["Expenses"].Points.AddXY("Выплаты зарплат", (MonthSalariesSumYear * 12));
                    ExpensesChart.Series["Expenses"].Points.AddXY("Сверхприбыль", (SalesTotalSumYear - (rent * 12) - (SalesTotalSumYear / 100 * 75) -
                                                                                     ((SalesTotalSumYear / 100 * 13) + taxes * 12) - (MonthSalariesSumYear * 12)));
                    break;

                case "Рассчитать":

                        // Очищаем поля от возможного заполнения 
                    totalEarningsBox.Items.Clear();
                    cleanEarningsBox.Items.Clear();
                    ordersTotalBox.Items.Clear();
                    employeesListBox.Items.Clear();
                    positionListBox.Items.Clear();
                    salaryListBox.Items.Clear();
                    popularOrderBox.Items.Clear();
                    rareOrderBox.Items.Clear();
                    ProfitabilityChart.Series["Profitability"].Points.Clear();
                    PopularityChart.Series["Popularity"].Points.Clear();
                    ExpensesChart.Series["Expenses"].Points.Clear();
                    SalaryBox.Items.Clear();

                        // Определяем номера начального и конечного месяцев
                    var salesStartsInPeriod = sales.array.Where(Sales => Sales.monthName == startMonthBox.Text).Max(Sales => Sales.monthNum);
                    var salesEndsInPeriod = sales.array.Where(Sales => Sales.monthName == endMonthBox.Text).Max(Sales => Sales.monthNum);

                        // Проверяем правтльность выбранных значений
                    if (salesStartsInPeriod >= salesEndsInPeriod)
                    {
                        MessageBox.Show("Ошибка ввода!!!");

                    } else if (salesStartsInPeriod < salesEndsInPeriod)
                    {
                        var salesInPeriod = sales.array.Where(Sales => Sales.monthNum >= salesStartsInPeriod && Sales.monthNum < salesEndsInPeriod);

                            // Определяем и выводим сколько всего заработал ресторан за выбранный промежуток
                        var SalesTotalSumPeriod = salesInPeriod.Sum(Sales => Sales.totalEarned);
                        totalEarningsBox.Items.Add(SalesTotalSumPeriod + " ₽".ToString());

                            // Находим сумму всех зарплат сотрудников за выбранный промежуток
                        var MonthSalariesSumPeriod = employee.array.Sum(Employee => Employee.Salary);

                            // Выводим в строку "Аренда" сумму оплаты аренды за выбранный промежуток
                        rentBox.Text = (rent * (salesInPeriod.Count() / 7) + " ₽");

                            // Выводим в строку "Производственные расходы" сумму расходов за выбранный промежуток
                        productionPurchasesBox.Text = ((SalesTotalSumPeriod / 100 * 75) + " ₽").ToString();

                            // Выводим в строку "Налоги" сумму налога за выбранный промежуток
                        taxesBox.Text = (((SalesTotalSumPeriod / 100 * 13) + taxes * (salesInPeriod.Count() / 7)) + " ₽").ToString();

                        SalaryBox.Items.Add((MonthSalariesSumPeriod * (salesInPeriod.Count() / 7)) + " ₽");

                            // Выводим данные в строку "Чистая прибыль ресторана" за выбранный промежуток
                        cleanEarningsBox.Items.Add(SalesTotalSumPeriod - (rent * (salesInPeriod.Count() / 7)) - (SalesTotalSumPeriod / 100 * 75) -
                                                  ((SalesTotalSumPeriod / 100 * 13) + taxes * (salesInPeriod.Count() / 7)) -
                                                  (MonthSalariesSumPeriod * (salesInPeriod.Count() / 7)) + " ₽").ToString();

                            // Выводим на экран список сотрудников, их должности и зарплаты за выбранный промежуток                   
                        foreach (Employee employees in employee.array)
                        {
                            employeesListBox.Items.Add(employees.firstName + " " + employees.lastName);
                            positionListBox.Items.Add(employees.Position);
                            salaryListBox.Items.Add(employees.Salary * (salesInPeriod.Count() / 7));
                        }

                            // Находим и выводим общее количество заказанных блюд за выбранный ппромежуток 
                        var TotalOrdersSumPeriod = salesInPeriod.Sum(Sales => Sales.quantity);
                        ordersTotalBox.Items.Add(TotalOrdersSumPeriod + " Блюд".ToString());

                            // Находим и выводим название самого популярного блюда за выбранный ппромежуток
                        var OrderMaxPeriod = salesInPeriod.Max(Sales => Sales.quantity);
                        var MostPopularOrderPeriod = salesInPeriod.Where(Sales => Sales.quantity == OrderMaxPeriod);
                        foreach (Sales sale in MostPopularOrderPeriod)
                        {
                            popularOrderBox.Items.Add(sale.dishName);
                        }

                            // Находим и выводим название самого не популярного блюда за выбранный ппромежуток
                        var OrderMinPeriod = salesInPeriod.Min(Sales => Sales.quantity);
                        var RareOrderPeriod = salesInPeriod.Where(Sales => Sales.quantity == OrderMinPeriod);
                        foreach (Sales sale in RareOrderPeriod)
                        {
                            rareOrderBox.Items.Add(sale.dishName);
                        }

                            // Заполняем графики прибыли блюд за выбранный ппромежуток
                        ProfitabilityChart.Series["Profitability"].Points.AddXY("Kalakeitto", salesInPeriod.Where(Sales => Sales.dishName == "Kalakeitto").Sum(Sales => Sales.totalEarned));
                        ProfitabilityChart.Series["Profitability"].Points.AddXY("Hernekeitto", salesInPeriod.Where(Sales => Sales.dishName == "Hernekeitto").Sum(Sales => Sales.totalEarned));
                        ProfitabilityChart.Series["Profitability"].Points.AddXY("Leipäjuusto", salesInPeriod.Where(Sales => Sales.dishName == "Leipäjuusto").Sum(Sales => Sales.totalEarned));
                        ProfitabilityChart.Series["Profitability"].Points.AddXY("Graavilohi", salesInPeriod.Where(Sales => Sales.dishName == "Graavilohi").Sum(Sales => Sales.totalEarned));
                        ProfitabilityChart.Series["Profitability"].Points.AddXY("Kalakukko", salesInPeriod.Where(Sales => Sales.dishName == "Kalakukko").Sum(Sales => Sales.totalEarned));
                        ProfitabilityChart.Series["Profitability"].Points.AddXY("Sahti", salesInPeriod.Where(Sales => Sales.dishName == "Sahti").Sum(Sales => Sales.totalEarned));
                        ProfitabilityChart.Series["Profitability"].Points.AddXY("Minttu", salesInPeriod.Where(Sales => Sales.dishName == "Minttu").Sum(Sales => Sales.totalEarned));

                            // Заполняем график популярности блюд за выбранный ппромежуток
                        PopularityChart.Series["Popularity"].Points.AddXY("Kalakeitto", salesInPeriod.Where(Sales => Sales.dishName == "Kalakeitto").Sum(Sales => Sales.quantity));
                        PopularityChart.Series["Popularity"].Points.AddXY("Hernekeitto", salesInPeriod.Where(Sales => Sales.dishName == "Hernekeitto").Sum(Sales => Sales.quantity));
                        PopularityChart.Series["Popularity"].Points.AddXY("Leipäjuusto", salesInPeriod.Where(Sales => Sales.dishName == "Leipäjuusto").Sum(Sales => Sales.quantity));
                        PopularityChart.Series["Popularity"].Points.AddXY("Graavilohi", salesInPeriod.Where(Sales => Sales.dishName == "Graavilohi").Sum(Sales => Sales.quantity));
                        PopularityChart.Series["Popularity"].Points.AddXY("Kalakukko", salesInPeriod.Where(Sales => Sales.dishName == "Kalakukko").Sum(Sales => Sales.quantity));
                        PopularityChart.Series["Popularity"].Points.AddXY("Sahti", salesInPeriod.Where(Sales => Sales.dishName == "Sahti").Sum(Sales => Sales.quantity));
                        PopularityChart.Series["Popularity"].Points.AddXY("Minttu", salesInPeriod.Where(Sales => Sales.dishName == "Minttu").Sum(Sales => Sales.quantity));

                            // Заполняем график распределиения прибыли за выбранный ппромежуток
                        ExpensesChart.Series["Expenses"].Points.AddXY("Налоги", (SalesTotalSumPeriod / 100 * 13) + taxes * (salesInPeriod.Count() / 7));
                        ExpensesChart.Series["Expenses"].Points.AddXY("Производство", (SalesTotalSumPeriod / 100 * 75));
                        ExpensesChart.Series["Expenses"].Points.AddXY("Аренда", (rent * (salesInPeriod.Count() / 7)));
                        ExpensesChart.Series["Expenses"].Points.AddXY("Выплаты зарплат", (MonthSalariesSumPeriod * (salesInPeriod.Count() / 7)));
                        ExpensesChart.Series["Expenses"].Points.AddXY("Сверхприбыль", (SalesTotalSumPeriod - (rent * (salesInPeriod.Count() / 7)) - (SalesTotalSumPeriod / 100 * 75) -
                                                                     ((SalesTotalSumPeriod / 100 * 13) + taxes * (salesInPeriod.Count() / 7)) -
                                                                     (MonthSalariesSumPeriod * (salesInPeriod.Count() / 7))));
                    }
                    break;
            }
        }

            // Создаём общий класс для всех кнопок меню
        private void foodButtons(object sender, EventArgs e)
        {
            System.Windows.Forms.Button foodButton = (System.Windows.Forms.Button)sender;

            switch (foodButton.Name)
            {
                case "graavilohiButton":

                        // Выводим форму с информацией о graavilohi
                    graavilohiForm form;
                    form = new graavilohiForm();
                    form.ShowDialog();
                    break;

                case "hernekeittoButton":

                        // Выводим форму с информацией о hernekeitto
                    hernekeittoForm form1;
                    form1 = new hernekeittoForm();
                    form1.ShowDialog();
                    break;

                case "kalakeittoButton":

                        // Выводим форму с информацией о kalakeitto
                    kalakeittoForm form2;
                    form2 = new kalakeittoForm();
                    form2.ShowDialog();
                    break;

                case "kulakukkoButton":

                        // Выводим форму с информацией о kalakukko
                    kalakukkoForm form3;
                    form3 = new kalakukkoForm();
                    form3.ShowDialog();
                    break;

                case "leipajustoButton":

                        // Выводим форму с информацией о leipajuusto
                    leipajuustoForm form4;
                    form4 = new leipajuustoForm();
                    form4.ShowDialog();
                    break;

                case "minttuButton":

                        // Выводим форму с информацией о minttu
                    minttuForm form5;
                    form5 = new minttuForm();
                    form5.ShowDialog();
                    break;

                case "sahtiButton":

                        // Выводим форму с информацией о sahti
                    sahtiForm form6;
                    form6 = new sahtiForm();
                    form6.ShowDialog();
                    break;               
            }
        }

            // Создаём класс для вывода информации о ресторане 
        private void info_Click(object sender, EventArgs e)
        {

                // Выводим форму информации о ресторане
            infoForm form;
            form = new infoForm();
            form.ShowDialog();
        }
    }
}
