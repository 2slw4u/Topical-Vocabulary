using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolQuizRandomized
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] quest = new string[37];
        string[] answer = new string[37];
        int i;
        Random R = new Random();
        int vern;
        int nevern;

        private void button1_Click(object sender, EventArgs e)
        {
            quest[0] = "Люди и государства доброй воли";
            quest[1] = "Стремиться к длящемуся миру";
            quest[2] = "Кооперироваться или объединять усилия с другими странами";
            quest[3] = "Устраивать международные встречи, конференции, саммиты, переговоры (2 варианта) по вопросу о войне и мире";
            quest[4] = "Подписывать международные договоры";
            quest[5] = "Пытаться сохранить международный мир и безопасность";
            quest[6] = "Пытаться запретить и постепенно уничтожить оружие массового поражения";
            quest[7] = "Делать что-то так хорошо, как возможно";
            quest[8] = "Решать локальные конфликты";
            quest[9] = "Восстановить мир в опасных зонах";
            quest[10] = "Предпринимать шаги к облегчению мировых волнений";
            quest[11] = "Обещать не использовать силу в международных отношениях";
            quest[12] = "Остановить террористические атаки";
            quest[13] = "Бороться против терроризма";
            quest[14] = "Спасти грядущие поколения от ужасов войны";
            quest[15] = "Уважать права стран и личностей";
            quest[16] = "Страны имеют право быть независимыми, иметь суверинитет и территориальную целостность";
            quest[17] = "Личности имеют (право иметь) гражданские и политические права и свободы (два варианта)";
            quest[18] = "Право работать";
            quest[19] = "Право на здравоохранение";
            quest[20] = "Право на образование";
            quest[21] = "Право путешествовать";
            quest[22] = "Право иметь собственность";
            quest[23] = "Право на жизнь";
            quest[24] = "Право на честный суд";
            quest[25] = "Объявлены или не объявлены";
            quest[26] = "Предоставлены или не предоставлены им";
            quest[27] = "Соблюдены(уважаемы) или не соблюдены";
            quest[28] = "Защищены или не защищены";
            quest[29] = "Соблюдены или не соблюдены";
            quest[30] = "Осуществлены или не осуществлены";
            quest[31] = "Нарушены или не нарушены";
            quest[32] = "Ущемлены или не ущемлены";
            quest[33] = "Человеческое отношение к гражданским во время войны";
            quest[34] = "Защита больных и раненых солдат";
            quest[35] = "Справедливое обращение с пленными войны, беженцами и заложниками";
            quest[36] = "Благодаря этим законам каждый человек может жаловаться на нарушение человеческих прав";

            answer[0] = "Peoples and governments of goodwill";
            answer[1] = "To aspire to a lasting peace";
            answer[2] = "To cooperate or unite efforts with other countries";
            answer[3] = "To hold international meetings, conferences, summits, negotiations, talks on problems of war and peace";
            answer[4] = "To sign international treaties";
            answer[5] = "To try to keep international peace and security";
            answer[6] = "To seek to ban and gradually destroy weapons of mass destruction";
            answer[7] = "To do one's best";
            answer[8] = "To settle local conflicts";
            answer[9] = "To restore peace in troubled areas";
            answer[10] = "To take steps to ease world tensions";
            answer[11] = "To pledge not to use force in international relations";
            answer[12] = "To stop terrorist attacks";
            answer[13] = "To fight against terrorism";
            answer[14] = "To save generations to come from the horrors of war";
            answer[15] = "To recognize the rights of countries and individuals";
            answer[16] = "Countries are entitled to independence, sovereignty and territorial integrity";
            answer[17] = "Individuals are entitled to civil and political rights and liberties/freedoms";
            answer[18] = "The right to work";
            answer[19] = "The right to health care";
            answer[20] = "The right to education";
            answer[21] = "The right to travel";
            answer[22] = "The right to housing";
            answer[23] = "The right to life";
            answer[24] = "The right to fair trial";
            answer[25] = "Declared or not declared";
            answer[26] = "Provided or not provided to them";
            answer[27] = "Respected or not respected";
            answer[28] = "Protected or not protected";
            answer[29] = "Observed or not observed";
            answer[30] = "Implemented or not implemented";
            answer[31] = "Violated or not violated";
            answer[32] = "Abused or not abused";
            answer[33] = "Human treatment of civilians in wartime";
            answer[34] = "Protection for sick and wounded soldiers";
            answer[35] = "Fair treatment of prisoners of war, refugees and hostages";
            answer[36] = "Thanks to such laws every person can complain about human rights violation";

            i = R.Next(0, 37);
            textBox1.Text = quest[i];
            vern = 0;
            nevern = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == answer[i])
            {
                label3.Text = "Итог: всё верно!";
                label5.Text = "Ваш ответ: " + textBox2.Text;
                label4.Text = "Верный ответ: " + answer[i];
                vern++;
            } else if (textBox2.Text == "last +") {
                label3.Text = "Gottcha";
                label5.Text = "Ваш прошлый ответ был верным";
                label4.Text = "Верный ответ: " + answer[i];
                vern++;
                nevern--;
            } else
            {
                label3.Text = "Итог: неверно";
                label5.Text = "Ваш ответ: " + textBox2.Text;
                label4.Text = "Верный ответ: " + answer[i];
                nevern++;
            }
            if (nevern < 0) nevern = 0;
            textBox2.Text = "";
            label6.Text = "Соотношение ответов - " + vern + "/" + nevern;
            label7.Text = "Процент верных ответов - " + (vern * 100 / (vern + nevern)) + "%";
            i = R.Next(0, 37);
            textBox1.Text = quest[i];

            if ((vern * 100 / (vern + nevern)) >= 60 && (vern * 100 / (vern + nevern)) <= 74)
            {
                label8.Text = "Ваша оценка - 3. Старайтесь больше.";
            } else if ((vern * 100 / (vern + nevern)) > 74 && (vern * 100 / (vern + nevern)) <= 89)
            {
                label8.Text = "Ваша оценка - 4. Очень даже неплохо, но вы сможете лучше.";
            } else if ((vern * 100 / (vern + nevern)) > 89 )
            {
                label8.Text = "Ваша оценка - 5! Невероятно! Прекрасная работа!";
            } else if ((vern * 100 / (vern + nevern)) < 60)
            {
                label8.Text = "Ваша оценка - 2. Либо вы ответили на малое количество вопросов, либо стоило лучше учить.";
            }
        }

    }
}
