using System;

namespace SimpleBloodQuiz
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            new ArekBloodQuiz(); // tu odpalam swoj test
            
            /* 
             * 1. Czy da się to krócej zapisać (ArrayList?)
             * +2. Jak zapisać, żeby przy złej odpowiedzi można było spróbować ponownie
             *    aż do uzyskania prawidłowej odpowiedzi (for loop ze stringami?)
             * 3. Jakie pliki powstają przy tworzeniu projektu i które wysyłać,
             *    żeby program działał u kogoś innego (.sln, .csproj?)
             * 4. Co zrobić, żeby zamieniał kolejność odpowiedzi w pytaniach na losową (jakiś random?)
             * 5. Jak zrobić aplikację w oknie  -- aplikacja WPF
             */


            //ponizej zostawiam w stanie jak zostawil Bartek

            Console.Clear();
            Console.WriteLine("Oryginalny quiz");

            QuestionAnswerEntity[] QuestionsAndAnswers = new QuestionAnswerEntity[9];

            QuestionsAndAnswers[0] = new QuestionAnswerEntity { Question = "1.Gdzie znajdują się komórki krwiotwórcze ? ", AnswersList = new[] { "\na) w wątrobie", "\nb) w sercu", "\nc) w szpiku", "\nd) w śledzionie" }, Answer = "c" };

            


            Console.WriteLine("To jest krótki quiz o krwi.");
            int score = 0;

            for (int i = 0; i < QuestionsAndAnswers.Length; i++)
            {
                Console.WriteLine(QuestionsAndAnswers[i].Question);

                String answ = Console.ReadLine();


                if (answ == QuestionsAndAnswers[i].Answer) score++; //score nabija się tylko, jeśli pierwsza odp jest poprawna

                for (; answ != QuestionsAndAnswers[i].Answer;)
                {
                    Console.WriteLine("Źle, spróbuj ponownie");
                    answ = Console.ReadLine();
                }
                if (answ == QuestionsAndAnswers[i].Answer)
                {
                    Console.WriteLine("Dobrze");
                }
            }

            //Pytanie 1 - powstawanie komórek krwi, hematopoeza
            Console.WriteLine("1. Gdzie znajdują się komórki krwiotwórcze?" +
                              "\na) w wątrobie" +
                              "\nb) w sercu" +
                              "\nc) w szpiku" +
                              "\nd) w śledzionie");
            String ans1 = Console.ReadLine();


            if (ans1 == "c") score++; //score nabija się tylko, jeśli pierwsza odp jest poprawna

            for (; ans1 != "c";)
            {
                Console.WriteLine("Źle, spróbuj ponownie");
                ans1 = Console.ReadLine();
            }
            if (ans1 == "c")
            {
                Console.WriteLine("Dobrze");
            }

            //Pytanie 2
            Console.WriteLine("2. Erytropoetyna, hormon pobudzający komórki macierzyste do produkcji erytrocytów, jest wydzielana przez:" +
                             "\na) nerki" +
                             "\nb) serce" +
                             "\nc) szpik kostny" +
                             "\nd) tarczycę");
            String ans2 = Console.ReadLine();


            if (ans2 == "a") score++;

            for (; ans2 != "a";)
            {
                Console.WriteLine("Źle, spróbuj ponownie");
                ans2 = Console.ReadLine();
            }
            if (ans2 == "a")
            {
                Console.WriteLine("Dobrze");
            }


            //Pytanie 3 - rodzaje komórek krwi, ich liczba i stosunek procentowy
            Console.WriteLine("3. W prawidłowym rozmazie krwi najmniej jest:" +
                              "\na) monocytów" +
                              "\nb) bazofili" +
                              "\nc) trombocytów" +
                              "\nd) eozynofili");
            String ans3 = Console.ReadLine();


            if (ans3 == "b") score++;

            for (; ans3 != "b";)
            {
                Console.WriteLine("Źle, spróbuj ponownie");
                ans3 = Console.ReadLine();
            }
            if (ans3 == "b")
            {
                Console.WriteLine("Dobrze");
            }

            //Pytanie 4
            Console.WriteLine("4. Eozynofil to inaczej:" +
                              "\na) granulocyt kwasochłonny" +
                              "\nb) granulocyt obojętnochłonny" +
                              "\nc) agranulocyt" +
                              "\nd) granulocyt zasadochłonny");
            String ans4 = Console.ReadLine();


            if (ans4 == "a") score++;

            for (; ans4 != "a";)
            {
                Console.WriteLine("Źle, spróbuj ponownie");
                ans4 = Console.ReadLine();
            }
            if (ans4 == "a")
            {
                Console.WriteLine("Dobrze");
            }

            //Pytanie 5 - funkcje poszczególnych komórek
            Console.WriteLine("5. Komórki produkujące przeciwciała to:" +
                              "\na) Limfocyty B" +
                              "\nb) Limfocyty Tc" +
                              "\nc) Limfocyty Th" +
                              "\nd) Limfocyty Treg");
            String ans5 = Console.ReadLine();


            if (ans5 == "a") score++;

            for (; ans5 != "a";)
            {
                Console.WriteLine("Źle, spróbuj ponownie");
                ans5 = Console.ReadLine();
            }
            if (ans5 == "a")
            {
                Console.WriteLine("Dobrze");
            }

            //Pytanie 6
            Console.WriteLine("6. Zdolności do fagocytozy NIE posiadają:" +
                              "\na) monocyty" +
                              "\nb) bazofile" +
                              "\nc) trombocyty" +
                              "\nd) neutrofile");
            String ans6 = Console.ReadLine();


            if (ans6 == "c") score++;

            for (; ans6 != "c";)
            {
                Console.WriteLine("Źle, spróbuj ponownie");
                ans6 = Console.ReadLine();
            }
            if (ans6 == "c")
            {
                Console.WriteLine("Dobrze");
            }

            //Pytanie 7 - parametry na wyniku morfologii, czynniki wpływające na wynik
            Console.WriteLine("7. MCV na wyniku morfologii krwi oznacza:" +
                              "\na) liczbę erytrocytów/ml" +
                              "\nb) średnią masę hemoglobiny w erytrocycie" +
                              "\nc) liczbę leukocytów/ml" +
                              "\nd) średnią objętość erytrocytów");
            String ans7 = Console.ReadLine();


            if (ans7 == "d") score++;

            for (; ans7 != "d";)
            {
                Console.WriteLine("Źle, spróbuj ponownie");
                ans7 = Console.ReadLine();
            }
            if (ans7 == "d")
            {
                Console.WriteLine("Dobrze");
            }

            //Pytanie 8
            Console.WriteLine("8. MCV może być podwyższone z powodu:" +
                              "\na) niedoboru żelaza" +
                              "\nb) odwodnienia hipertonicznego" +
                              "\nc) przewodnienia hipertonicznego" +
                              "\nd) niedoboru witaminy B12");
            String ans8 = Console.ReadLine();


            if (ans8 == "d") score++;

            for (; ans8 != "d";)
            {
                Console.WriteLine("Źle, spróbuj ponownie");
                ans8 = Console.ReadLine();
            }
            if (ans8 == "d")
            {
                Console.WriteLine("Dobrze");
            }

            //Pytanie 9 - czas życia komórek krwi, produkty rozpadu, funkcje wątroby
            Console.WriteLine("9. Produktem metabolizmu hemoglobiny jest:" +
                              "\na) mioglobina" +
                              "\nb) lipaza" +
                              "\nc) bilirubina" +
                              "\nd) amylaza");
            String ans9 = Console.ReadLine();


            if (ans9 == "c") score++;

            for (; ans9 != "c";)
            {
                Console.WriteLine("Źle, spróbuj ponownie");
                ans9 = Console.ReadLine();
            }
            if (ans9 == "c")
            {
                Console.WriteLine("Dobrze");
            }

            /* inna wersja testu - pyta o odp tylko raz i od razu podaje prawidłową
            if (ans9 == "c") {
                score++;
                Console.WriteLine("Dobrze!");
            } else {
                Console.WriteLine("Źle, poprawna odpowiedź to c.");
            }
            */


            Console.WriteLine("KONIEC. Twój wynik to: " + score + "/9");
        }

    }
}
