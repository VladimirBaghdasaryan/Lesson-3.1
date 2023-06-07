using System.ComponentModel.Design;
using System.Timers;

namespace Lesson_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Տրված են իրարից տարբեր a, b, թվերը: Կազմել բլոկ-սխեմա և ծրագիր, որոնք
            //int a = 4;
            //int b = 9;
            //21.կարտածեն տրված թվերից մեծի արժեքը:

            //if (a>b)
            //{
            //    Console.WriteLine(a);
            //}
            //else
            //{
            //    Console.WriteLine(b);
            //}

            //int max=Math.Max(a, b);
            //Console.WriteLine(max);

            //22.կարտածեն տրված թվերից փոքրի արժեքը:


            //if (a < b)
            //{
            //    Console.WriteLine(a);
            //}
            //else
            //{
            //    Console.WriteLine(b);
            //}

            //int min = Math.Min(a, b);
            //Console.WriteLine(min);

            //23.եթե տրված թվերից գոնե մեկը հավասար է մեկի, ապա կարտածեն
            //true, հակառակ դեպքում' false:

            //if (a==1||b==1)
            //{
            //    Console.WriteLine(true);
            //}
            //else
            //{
            //    Console.WriteLine(false);
            //}

            //bool  isEqualToOne = (a == 1) || (b == 1);
            //Console.WriteLine(isEqualToOne);

            //24.եթե տրված թվերից ճիշտ երկուսը հավասար են երկուսի, ապա
            //կարտածեն true, հակառակ դեպքում' false; 

            //if (a == 2 && b == 2)
            //{
            //    Console.WriteLine(true);
            //}
            //else
            //{
            //    Console.WriteLine(false);
            //}

            //bool isEqualToTwo = (a == 2 && b == 2);
            //Console.WriteLine(isEqualToTwo);






            //26.կարտածեն մեկ, եթե տրված թվերից գոնե մեկը զույգ է, այլապես' երկու:

            //if (a%2 == 0 || b%2 == 0)
            //{
            //    Console.WriteLine(1);
            //}
            //else
            //{
            //    Console.WriteLine(2);
            //}

            //27.կարտածեն true, եթե տրված թվերը թվաբանական պրոգրեսիա են
            //կազմում, հակառակ դեպքում' fatse:

            //if (b-a==0)
            //{
            //    Console.WriteLine(false);
            //}
            //else
            //{
            //    Console.WriteLine(true);
            //}

            //28.կարտածեն true, եթե տրված թվերը երկրաչափական պրոգրեսիա են կազմում, 
            //հակառակ դեպքում' false;

            //if (b / a==0)
            //{
            //    Console.WriteLine(false);
            //}
            //else
            //{
            //    Console.WriteLine(true);
            //}


            //տրված թվերը կարտածեն ըստ աճման կարգի հաջորդականության:

            //if (a > b)
            //{
            //    Console.WriteLine($"{b} {a}");
            //}
            //else
            //{
            //    Console.WriteLine($"{a} {b}");

            //}

            //30.տրված թվերը կարտածեն ըստ նվազման կարգի հաջորդականության:

            //if (a > b)
            //{
            //    Console.WriteLine($"{a} {b}");
            //}
            //else
            //{
            //    Console.WriteLine($"{b} {a}");

            //}



            //Տրված են իրարից տարբեր a, b, c և d թվերը: Կազմել բլոկ-սխեմա և ծրագիր, որոնք

            //int a = 4;
            //int b = 9;
            //int c = 15;
            //int d = 24;

            //31.կարտածեն տրված թվերից մեծագույնի արժեքը:

            //int max = a;
            //if (b > max)
            //{
            //    max = b;
            //}
            //if (c > max)
            //{
            //    max = c;
            //}
            //if (d > max)
            //{
            //    max = d;
            //}
            //Console.WriteLine(max);


            //32.կարտածեն տրված թվերից փոքրագույնի արժեքը:

            //int min = a;
            //if (b < min)
            //{
            //    min = b;
            //}
            //if (c < min)
            //{
            //    min = c;
            //}
            //if (d < min)
            //{
            //    min = d;
            //}
            //Console.WriteLine(min);


            //33.կարտածեն true, եթե տրված թվերից գոնե մեկը հավասար է մեկի, այլապես' false;

            //if (a==1 || b==1 || c==1 || d==1)
            //{
            //    Console.WriteLine(true);
            //}
            //else
            //{
            //    Console.WriteLine(false);
            //}

            //34.եթե տրված թվերից երկուսի գումարը հավասար է մյուս երկուսի գումարին, 
            //   ապա կարտածեն true, հակառակ դեպքում' false; 

            //if (a+b==c+d)
            //{
            //    Console.WriteLine(true);
            //}
            //else
            //{
            //    Console.WriteLine(false);
            //}


            //35.եթե տրված թվերից մեկը հավասար է մյուս երեք թվերի գումարին, ապա կարտածեն true, հակառակ դեպքում' false; 

            //if (a==(a+b+c) || b==(a+c+d) || c==(a+b+d) || d==(a+b+c))
            //{
            //    Console.WriteLine(true);
            //}
            //else
            //{
            //    Console.WriteLine(false);
            //}

            //36.եթե տրված թվերից գոնե երկուսը կենտ են, ապա կարտածեն մեկ. հակառակ դեպքում' երկու;

            //if ((a%2!=0 || b%2!=0) || (a % 2 != 0 || c % 2 != 0) || (a % 2 != 0 || d % 2 != 0) || (a % 2 != 0 || d % 2 != 0)
            //   || (b % 2 != 0 || c % 2 != 0) || (d % 2 != 0 || c % 2 != 0) || (b % 2 != 0 || d % 2 != 0))
            //{
            //    Console.WriteLine(1);
            //}
            //else
            //{
            //    Console.WriteLine(2);
            //}

            //37.կարտածեն true, եթե տրված թվերը կազմում են թվաբանական պրոգրեսիա,
            //   ապա կարտածեն true, հակառակ դեպքում' false;

            //if ((b-a)==(c-b) && (c - b) == (d - c)) 
            //{
            //    Console.WriteLine(true);
            //}
            //else
            //{
            //    Console.WriteLine(false);
            //}


            //38.եթե տրված թվերը կազմում են երկրաչափական պրոգրեսիա,  ապա կարտածեն true, հակառակ դեպքում' false;

            //if ((b / a) == (c / b) && (c / b) == (d / c))
            //{
            //    Console.WriteLine(true);
            //}
            //else
            //{
            //    Console.WriteLine(false);
            //}

            //39.տրված թվերը կարտածեն ըստ աճման կարգի հաջորդականության;

            //int[] array = { a, b, c, d };
            //Array.Sort(array);
            //foreach (int item in array)
            //{
            //    Console.Write(item + " ");
            //}


            //40.տրված թվերը կարտածեն ըստ նվազման հաջորդականության կարգի

            //int[] array1 = { a, b, c, d };
            //Array.Sort(array1);
            //Array.Reverse(array1);
            //foreach (int item in array1)
            //{
            //    Console.Write(item + " ");
            //}






            //Տրված է եռանիշ թիվ: Կազմել հետևյալ խնդիրների լուծման բլոկ - սխեման և ծրագիրը:

            //int i = Convert.ToInt32(Console.ReadLine());

            //51.տրամաբանական տիպի փոփոխականին վերագրել արժեք, 
            //    եթե եռանիշ թվի միավորների թվանշանը հավասար է տասնավորների և հարյուրավորների թվանշանների գումարին,
            //    հակառակ դեպքում false: Արտածել է փոփոխականի արժեքը:


            //int haryuravor = i % 10;
            //int tasnavor = (i / 10) % 10;
            //int miavor = i / 100;

            //bool b = miavor == tasnavor + haryuravor;
            //Console.WriteLine(i + " " + b);


            //  52.Տրամաբանական փոփոխականին վերագրել true արժեք, եթե
            //եռանիշ թվի թվանշանների մեջ կան իրար հավասար թվանշաններ, հակառակ դեպքում false: Արտածել է փոփոխականի արժեքը:


            //int haryuravor = i % 10;
            //int tasnavor = (i / 10) % 10;
            //int miavor = i / 100;

            //bool b = ( miavor==tasnavor )|| (miavor == haryuravor )|| (tasnavor == haryuravor) ;
            //Console.WriteLine(i + " " + b);


            //53.Հաշվել և արտածել եռանիշ թվի և իր թվանշանների գումարի հարաբերության արժեքը, 
            //եթե եռանիշ թիվը մեծ է տրված k թվից, հակառակ դեպքում միավորների թվանշանի և եռանիշ թվի հարաբերության արժեքը:

            //int sum = (miavor + tasnavor + haryuravor);
            //if (i>sum)
            //{
            //    Console.WriteLine(i/sum);
            //}
            //else
            //{
            //    Console.WriteLine(sum/i);
            //}


            //54.Հաշվել և արտածել եռանիշ թվի թվանշաններից մեծագույնի արժեքը:
            //int max = miavor;
            //if (tasnavor > max)
            //{
            //    max = tasnavor;
            //}
            //if (haryuravor > max)
            //{
            //    max = haryuravor;
            //}
            //Console.WriteLine(max);


            //55.Հաշվել և արտածել եռանիշ թվի թվանշաններից փոքրագույնի արժեքը:

            //int min = miavor;
            //if (tasnavor < min)
            //{
            //    min = tasnavor;
            //}
            //if (haryuravor < min)
            //{
            //    min = haryuravor;
            //}
            //Console.WriteLine(min);


            //56.Հաշվել և արտածել եռանիշ թվի թվանշանների գումարի և եռանիշ թվի հարաբերության արժեքը, 
            //   եթե միավորների թվանշանը մեծ է տասնավորների թվանշանից, հակառակ դեպքում արտածել եռանիշ թիվը:

            //int sum = (miavor + tasnavor + haryuravor);
            //if (miavor > tasnavor)
            //{
            //    Console.WriteLine(i / sum);
            //}
            //else
            //{
            //    Console.WriteLine(i);
            //}

            //57.Հաշվել և արտածել եռանիշ թվի տասնավորների և միավորների թվանշանների հարաբերության արժեքը,
            //   եթե եռանիշ թիվը մեծ է 300 - ից, հակառակ դեպքում հարյուրավորների և միավորների հարաբերության արժեքը: 
            //   Ենթադրվում է, որ եռանիշ թվի միավորների թվանշանը հավասար չէ զրոյի:

            //if (i>300 && miavor !=0)
            //{
            //    Console.WriteLine(tasnavor/miavor);
            //}
            //else
            //{
            //    Console.WriteLine(haryuravor/miavor);
            //}

            //58.Սիմվոլային f փոփոխականին վերագրել 'a' արժեքը, եթե եռանիշ թվի տասնավորների և հարյուրավորների թվանշանների
            //    գումարը փոքր է 5 - ից, հակառակ դեպքում'b' արժեքը: Արտածել f-ի արժեքը:

            //char f;
            //if ((tasnavor + haryuravor)<5)
            //{
            //    f = 'a';
            //}
            //else
            //{
            //    f = 'b';
            //}
            //Console.WriteLine(f);

            //59.Արտածել եռանիշ թվի թվանշանները ըստ աճման կարգի հաջորդականության:
            //int[] arr = { miavor, tasnavor, haryuravor };
            //Array.Sort(arr);
            //foreach (var item in arr)
            //{
            //    Console.Write(item);
            //}

            //60.Արտածել եռանիշ թվի թվանշանները ըստ նվազման կարգի հաջորդականության:


            //int[] arr = { miavor, tasnavor, haryuravor };
            //Array.Sort(arr);
            //Array.Reverse(arr);
            //foreach (var item in arr)
            //{
            //    Console.Write(item);
            //}


            //Տրված է քառանիշ թիվ: Կազմել հետևյալ խնդիրների լուծման բլոկ - սխեման և ծրագիրը:
            //int i = Convert.ToInt32(Console.ReadLine());

            //int hazaravor = i % 10;
            //int haryuravor = (i / 10) % 10;
            //int tasnavor = (i / 100) % 10;
            //int miavor = i / 1000;


            //61. տրամաբանական տիպի փոփոխականին վերագրել true արժեք.եթե թվի միավորների և տասնավորների
            //    թվանշանների գումարը հավասար է հարյուրավորների և հազարավորների թվանշանների գումարին, հակառակ դեպքում false:


            //bool bb = (miavor + haryuravor) == (haryuravor + hazaravor);
            //Console.WriteLine(bb);


            //62.Հաշվել և արտածել քառանիշ թվի հարաբերության արժեքը միավորների և հարյուրավորների թվանշանների գումարին, 
            //    եթե քառանիշ թիվը փոքր է 5000 - ից, հակառակ դեպքում քառանիշ թվի հարաբերության արժեքը
            //    հազարավորների ու տասնավորների թվանշանների գումարին: 
            //   Ենթադրվում է, որ քառանիշ թվի միավորների և հարյուրավորների թվանշանների գումարը հավասած չէ զրոյի: 

            //if (i<5000 && (miavor + haryuravor)!=0)
            //{
            //    Console.WriteLine(i/(miavor+haryuravor));
            //}
            //else
            //{
            //    Console.WriteLine(i/(hazaravor + tasnavor));
            //}

            //63.Արտածել 1, եթե քառանիշ թվի թվանշանների մեջ կա '1' թվանշանը, հակառակ դեպքում 0:

            //if (miavor == 1 || tasnavor ==1 || haryuravor==1 || hazaravor==1)
            //{
            //    Console.WriteLine(1);
            //}
            //else
            //{
            //    Console.WriteLine(0);
            //}


            //64.Սիմվոլային փոփոխականին վերագրել 's' արժեքը, եթե քառանիշ
            //  թվի միավորների և տասնավորների թվանշանների գումարը հավասար է 5 - ի, 
            //  հակառակ դեպքում  'd' արժեքը: Արտածել y-ի արժեքը:

            //char ch;
            //if (miavor + tasnavor == 5)
            //{
            //    ch = 's';
            //}
            //else
            //{
            //    ch = 'd';
            //}
            //Console.WriteLine(ch);

            //65.Արտածել 'y=12' արտահայտությունը, եթե միավորների և տասնավորների թվանշանների արտադրյալը հավասար է 12 - ի,
            //   հակառակ դեպքում' y=0' արտահայտությունը:

            //if (miavor * tasnavor==12)
            //{
            //    Console.WriteLine("y=12");
            //}
            //else
            //{
            //    Console.WriteLine("y=0");
            //}


            //66.Արտածել 'YES' հաղորդագրությունը, եթե քառանիշ թվի առաջին և վերջին թվանշանների մեջ կա '4' թվանշանը, 
            //   հակառակ դեպքում 'NO' հաղորդագրությունը:

            //if (miavor == 4 && hazaravor == 4)
            //{
            //    Console.WriteLine("Yes");
            //}
            //else
            //{
            //    Console.WriteLine("No");
            //}


            //67.Արտածել "YES" հաղորդագրությունը, եթե քառանիշ թիվը հավասար է իր թվանշանների գումարի քառակուսուն,
            //   հակառակ դեպքում 'NO' հաղորդագրությունը:

            //int sum = miavor + tasnavor + haryuravor + hazaravor;
            //if ((i*i)==(sum*sum))
            //{
            //    Console.WriteLine("Yes");
            //}
            //else
            //{
            //    Console.WriteLine("No");
            //}


            //68.Հաշվել և արտածել քառանիշ թվի միավորների և հարյուրավորների
            //  թվանշանների արտադրյալի արժեքը, եթե միավորների թվանշանը մեծ է տասնավորների թվանշանից,
            //  հակառակ դեպքում արտածել 1:

            //if (miavor > tasnavor)
            //{
            //    Console.WriteLine(i*(miavor+haryuravor));
            //}
            //else
            //{
            //    Console.WriteLine(1);
            //}


            //69.y փոփոխականին վերագրել 1 արժեքը.եթե քառանիշ թվի թվանշանների գումարը մեծ է 20 - ից,
            //   հակառակ դեպքում 0 արժեքը: Արտածել փոփոխականի արժեքը:

            //int y;
            //if ((miavor + tasnavor + haryuravor + hazaravor)>20)
            //{
            //    y = 1;
            //}
            //else
            //{
            //    y = 0;
            //}

            //Console.WriteLine(y);


            //70.y փոփոխականին վերագրել 0 արժեքը, եթե քառոնիշ թվի թվանշանների արտադրյալը մեծ է 200 - ից,
            //    հակառակ դեպքում 1 արժեքը: Արտածել փոփոխականի արժեքը:

            //int y;
            //if ((miavor * tasnavor * haryuravor * hazaravor)>200)
            //{
            //    y = 0;
            //}
            //else
            //{
            //    y = 1;
            //}

            //Console.WriteLine(y);



            //Կազմել հետեյալ խնդիրների լուծման բլոկ - սխեմաները և ծրագրերը:

            //151.Տպել բոլոր այն բնական թվերի գումարը, որոնց վրա առանց մնացորդի բաժանվում է տրված ո բնական թիվը: 

            //int num = Convert.ToInt32(Console.ReadLine());
            //int sum = 0;
            //for (int i = 1; i <= num; i++)
            //{
            //    if (num% i ==0)
            //    {
            //        sum += i;
            //    }
            //}
            //Console.WriteLine(sum);

            //152.Տպել բոլոր այն բնական թվերի արտադրյալը, որոնց վրա առանց մնացորդի բաժանվում է տրված ո բնական թիվը:

            //int num = Convert.ToInt32(Console.ReadLine());
            //int sum = 0;
            //for (int i = 1; i <= num; i++)
            //{
            //    if (num% i ==0)
            //    {
            //        sum *= i;
            //    }
            //}
            //Console.WriteLine(sum);

            //153.Տպել բոլոր այն բնական թվերի գումարը, որոնց վրա տրված ո բնական թիվը բաժանելիս կմնա 2 մնացորդ:

            //int num = Convert.ToInt32(Console.ReadLine());
            //int sum = 0;
            //for (int i = 1; i <= num; i++)
            //{
            //    if (num % i == 2)
            //    {
            //        sum += i;
            //    }
            //}
            //Console.WriteLine(sum);

            //154.Տպել բոլոր այն բնական թվերի արտադրյալը, որոնց վրա տրված ո բնական թիվը բաժանելիս կմնա 3 մնացորդ:


            //int num = Convert.ToInt32(Console.ReadLine());
            //long sum = 1;
            //for (int i = 1; i <= num; i++)
            //{
            //    if (num % i == 3)
            //    {
            //        sum *= i;
            //    }
            //}
            //Console.WriteLine(sum);

            //155.Տպել բոլոր այն երկնիշ թվերի գումարը, որոնք բազմապատիկ են 3 թվին:


            //int sum = 0;
            //for (int i = 10; i <= 99; i++)
            //{
            //    if (i % 3 == 0)
            //    {
            //        sum += i;
            //    }
            //}
            //Console.WriteLine(sum);

            //156.Տպել բոլոր այն երկնիշ թվերի արտադրյալը, որոնք բազմապատիկ են 3 և 5 թվերին:
            //int sum = 1;
            //for (int i = 10; i <= 99; i++)
            //{
            //    if (i % 3 == 0 && i % 5 == 0)
            //    {
            //        sum *= i;
            //    }
            //}
            //Console.WriteLine(sum);


            //157.Տպել բոլոր այն եռանիշ թվերի գումարը, որոնք բազմապատիկ չեն 5 թվին:

            //int sum = 0;
            //for (int i = 100; i <= 999; i++)
            //{
            //    if (i % 5 != 0)
            //    {
            //        sum += i;
            //    }
            //}
            //Console.WriteLine(sum);


            //158.Տպել բոլոր այն եռանիշ թվերի արտադրյալը, որոնք բազմապատիկ չեն 2 և 3 թվերին:

            //int sum = 1;
            //for (int i = 100; i <= 999; i++)
            //{
            //    if (i % 2 != 0 && i % 3 != 0)
            //    {
            //        sum *= i;
            //    }
            //}
            //Console.WriteLine(sum);

            //159.բոլոր այն եռանիշ թվերի արտադրյալը, որոնք 3 - ի բաժանելիս կմնա 1 մնացորդ, իսկ 4 - ի բաժանելիս' 2 մնացորդ:

            //int sum = 1;
            //for (int i = 100; i <= 999; i++)
            //{
            //    if (i % 3 == 1 && i % 4 == 2)
            //    {
            //        sum *= i;
            //    }
            //}
            //Console.WriteLine(sum);


            //160.Տպել այն ամենափոքր եռանիշ թիվը, որը 16 - ով բազմապատկելիս դառնում է բնական թվի քառակուսի: 

            //int eranish = 100;

            //while (true)
            //{

            //    int sum = eranish * 16;
            //    int armat = (int)Math.Sqrt(sum);

            //    if (armat * armat == sum)
            //    {
            //        Console.WriteLine(eranish);
            //        break;
            //    }
            //    eranish++;
            //}

            //161.Տպել այն ամենափոքր քառանիշ թիվը, որը 26 - ով
            //   բազմապատկելիս դառնում է բնական թվի քառակուսի: 

            //int qaranish = 4000;

            //while (true)
            //{

            //    int sum = qaranish * 26;
            //    int armat = (int)Math.Sqrt(sum);

            //    if (armat * armat == sum)
            //    {
            //        Console.WriteLine(qaranish);
            //        break;
            //    }
            //    qaranish++;
            //}

            //162.Տպել այն ամենամեծ քառանիշ թիվը, որը 14 - ով բազմապատկելիս
            // դառնում է բնական թվի քառակուսի:


            //int qaranish = 9999;

            //while (true)
            //{

            //    int sum = qaranish * 14;
            //    int armat = (int)Math.Sqrt(sum);

            //    if (armat * armat == sum)
            //    {
            //        Console.WriteLine(qaranish);
            //        break;
            //    }
            //    qaranish--;
            //}

            //163.Տպել այն ամենամեծ քառանիշ թիվը, որը 18 - ով բազմապատկելիս
            //  դառնում է բնական թվի քառակուսի:

            //int qaranish = 9999;

            //while (true)
            //{

            //    int sum = qaranish * 18;
            //    int armat = (int)Math.Sqrt(sum);

            //    if (armat * armat == sum)
            //    {
            //        Console.WriteLine(qaranish);
            //        break;
            //    }
            //    qaranish--;
            //}

            //164.Տպել այն ամենափոքր եռանիշ թիվը, որի քառակուսի արմատը մեծ է տրված ո բնական թվից:


            //int num = Convert.ToInt32(Console.ReadLine());
            //int eranish = 100;

            //while (eranish <1000)
            //{


            //    int armat = (int)Math.Sqrt(eranish);

            //    if (armat > num )
            //    {
            //        Console.WriteLine(eranish);
            //        break;
            //    }
            //    eranish++;
            //}


            //Տրված է N բնական թիվը: Օգտագործելով ամբողջթվային բաժանումը և բաժանումից ստացված մնացորդը վերցնելու գործողությունը'

            //201.հաշվել և արտածել թվի թվանշանների քանակը

            int n = Convert.ToInt32(Console.ReadLine());
            //int count = 0;
            //while (n>0)
            //{
            //    n /= 10;
            //    count++;
            //}
            //Console.WriteLine(count);

            //202.հաշվել և արտածել թվի թվանշանների գումարը

            //int sum = 0;
            //while (n > 0)
            //{
            //    sum += n % 10;
            //    n /= 10;
            //}
            //Console.WriteLine(sum);


            //203.հաշվել և արտածել թվի թվանշանների արտադրյալը

            //int sum = 1;
            //while (n > 0)
            //{
            //    sum *= n % 10;
            //    n /= 10;
            //}
            //Console.WriteLine(sum);


            //204.արտածել թվի բոլոր թվանշանները աջից ձախ հաջորդականությամբ

            //while (n > 0) 
            //{
            //    int i=n%10;
            //    Console.Write(i + " ");
            //    n/=10;
            //}



            //207.արտածել true, եթե թվի թվանշանների մեջ կա 2 թվանշանը, հակառակ դեպքում' false
            //bool t=false;
            //while (n>0)
            //{


            //    if (n%10==2)
            //    {
            //        t = true;
            //        break;
            //    }
            //    n /= 10;


            //}
            //Console.WriteLine(t);

            //208.արտածել true, եթե թվի թվանշաններն իրար հավասար են, հակառակ դեպքում' false
            //bool t = false;
            //int nI2 = n % 10;
            //while (n > 0)
            //{
            //    int nI = n % 10;

            //    if ( nI2!= nI)
            //    {
            //        t = false;
            //        break;
            //    }
            //    else
            //    {
            //        t = true;
            //    }
            //    n /= 10;


            //}
            //Console.WriteLine(t);

            //209.արտածել true, եթե թվի թվանշանների մեջ կենտ թվանշան կա, հակառակ դեպքում' false,

            //bool t = false;
            //while (n > 0)
            //{


            //    if ((n % 10) % 2!=0)
            //    {
            //        t = true;
            //        break;
            //    }

            //    n /= 10;


            //}
            //Console.WriteLine(t);

            //210.արտածել true, եթե թվի կենտ համարով թվանշանների գումարը հավասար է
            //    զույգ համարով թվանշանների գումարին, հակառակ դեպքում' false,


            //int kent = 0;
            //int zuyg = 0;
            //int hamar = 0;
            //bool b = true;
            //while (n > 0)
            //{
            //    int nI = n % 10;

            //    if (hamar % 2 == 0)
            //    {
            //        kent += nI;
            //    }
            //    else
            //    {
            //        zuyg += nI;
            //    }
            //    n /= 10;
            //    hamar++;

            //}

            //b = kent == zuyg;
            //Console.WriteLine(b);



        }


    }
}