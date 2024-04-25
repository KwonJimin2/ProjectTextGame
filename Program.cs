using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography.X509Certificates;
using static System.Formats.Asn1.AsnWriter;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C2project
{
    public class Chartor
    {

        public int gold = 150000;
        public int level = 01;
        public int op = 10;
        public int dp = 5;
        public int hp = 100;


    }




        internal class Program
    {




        static void Main(string[] args)
        {

            Chartor chartor = new Chartor();

            string[] item = new string[7];

            item[0] = "수련자 갑옷   / 방어력 +5  / 수련에 도움을 주는 갑옷입니다.";
            item[1] = "무쇠 갑옷     / 방어력 +9  / 무쇠로 만들어져 튼튼한 갑옷입니다.";
            item[2] = "스파르타 갑옷 / 방어력 +15 / 스파르타 전사들이 사용했다는 전설의 갑옷입니다.";
            item[3] = "낡은 검       / 공격력 +2  / 쉽게 볼 수 있는 낡은 검입니다.";
            item[4] = "청동 도끼     / 공격력 +5  / 어디선가 사용됐던거 같은 도끼입니다.";
            item[5] = "스파르타 창   / 공격력 +7  / 스파르타 전사들이 사용했다는 전설의 창입니다.";
            item[6] = "용사의 검  / 공격력 +15  / 세상을 구할 용사들이 사용했다는 전설의 검입니다.";
















            string item1 = "Empty";
            string item2 = "Empty";
            string item3 = "Empty";
            string item4 = "Empty";
            string item5 = "Empty";

            string itemBuy1 = "1000 G";
            string itemBuy2 = "1500 G";
            string itemBuy3 = "3500 G";
            string itemBuy4 = "600 G";
            string itemBuy5 = "1500 G";
            string itemBuy6 = "3000 G";
            string itemBuy7 = "7500 G";

            string wrong = "";

            string insert1 = "";
            string insert2 = "";
            string insert3 = "";
            string insert4 = "";
            string insert5 = "";


            Console.Write("이름을 정해주세요. :");
            string name = Console.ReadLine();
            Console.Clear();


            MainScene();

            void MainScene()
            {
                Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다.");
                Console.WriteLine("이곳에서 던전으로 들어가기 전 활동을 할 수 있습니다.");
                Console.WriteLine("\n");
                Console.WriteLine("1. 상태 보기");
                Console.WriteLine("2. 인벤토리");
                Console.WriteLine("3. 상점");
                Console.WriteLine("\n");
                Console.Write("원하시는 행동을 입력해주세요. : {0}", wrong);
                string mainSceneAct = Console.ReadLine();

                if (mainSceneAct == "1")
                {
                    Console.Clear();
                    wrong = "";
                    StatusScene();
                }
                else if (mainSceneAct == "2")
                {
                    Console.Clear();
                    wrong = "";
                    InventoryScene();
                }
                else if (mainSceneAct == "3")
                {
                    Console.Clear();
                    wrong = "";
                    StoreScene();
                }
                else
                {
                    Console.Clear();
                    wrong = "잘못된 입력입니다.";
                    MainScene();
                }

            }


            void StatusScene()
            {                
                Console.WriteLine("상태 보기");
                Console.WriteLine("캐릭터의 정보가 표시됩니다.");
                Console.WriteLine("\n");
                Console.WriteLine("LV. {0}", chartor.level);
                Console.WriteLine("{0} (전사)", name);
                Console.WriteLine("공격력 : {0} (+{1}))", chartor.op, chartor.op - 10);              
                Console.WriteLine("방어력 : {0} (+{1}))", chartor.dp, chartor.dp - 5);
                Console.WriteLine("체력 : {0}", chartor.hp);
                Console.WriteLine("Gold : {0} G", chartor.gold);
                Console.WriteLine("\n");
                Console.WriteLine("0. 나가기");
                Console.WriteLine("\n");
                Console.Write("원하시는 행동을 입력해주세요. : {0}", wrong);

                string status = Console.ReadLine();

                if (status == "0")
                {
                    Console.Clear();
                    wrong = "";
                    MainScene();
                }
                else
                {
                    Console.Clear();
                    wrong = "잘못된 입력입니다.";
                    StatusScene();
                }
            }


            void InventoryScene()
            {
                Console.WriteLine("인벤토리");
                Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.");
                Console.WriteLine("\n");
                Console.WriteLine("[아이템 목록]");
                Console.WriteLine("- {0} {1}", insert1, item1);
                Console.WriteLine("- {0} {1}", insert2, item2);
                Console.WriteLine("- {0} {1}", insert3, item3);
                Console.WriteLine("- {0} {1}", insert4, item4);
                Console.WriteLine("- {0} {1}", insert5, item5);
                Console.WriteLine("\n");
                Console.WriteLine("1. 장착 관리");
                Console.WriteLine("0. 나가기");
                Console.WriteLine("\n");
                Console.Write("원하시는 행동을 입력해주세요. : {0}", wrong);
                string inventory = Console.ReadLine();

                if (inventory == "0")
                {
                    Console.Clear();
                    wrong = "";
                    MainScene();
                }
                else if (inventory == "1")
                {
                    Console.Clear();
                    wrong = "";
                    InventoryManegeScene();
                }
                else
                {
                    Console.Clear();
                    wrong = "잘못된 입력입니다.";
                    InventoryScene();
                }
            }



            void InventoryManegeScene()
            {
                Console.WriteLine("인벤토리 - 장착 관리");
                Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.");
                Console.WriteLine("\n");
                Console.WriteLine("[아이템 목록]");
                Console.WriteLine("- 1 {0} {1}", insert1, item1);
                Console.WriteLine("- 2 {0} {1}", insert2, item2);
                Console.WriteLine("- 3 {0} {1}", insert3, item3);
                Console.WriteLine("- 4 {0} {1}", insert4, item4);
                Console.WriteLine("- 5 {0} {1}", insert5, item5);
                Console.WriteLine("\n");
                Console.WriteLine("0. 나가기");
                Console.WriteLine("\n");
                Console.Write("원하시는 행동을 입력해주세요. : {0}", wrong);
                string inventoryManege = Console.ReadLine();
               


                void Insert1()
                {
                    if (insert1 == "")
                    {
                        insert1 = "[E]";  
                    }
                    else
                    {
                        insert1 = "";
                    }
                }
                void Insert2()
                {
                    if (insert2 == "")
                    {
                        insert2 = "[E]";
                    }
                    else
                    {
                        insert2 = "";
                    }
                }
                void Insert3()
                {
                    if (insert3 == "")
                    {
                        insert3 = "[E]";
                    }
                    else
                    {
                        insert3 = "";
                    }
                }
                void Insert4()
                {
                    if (insert4 == "")
                    {
                        insert4 = "[E]";
                    }
                    else
                    {
                        insert4 = "";
                    }
                }
                void Insert5()
                {
                    if (insert5 == "")
                    {
                        insert5 = "[E]";
                    }
                    else
                    {
                        insert5 = "";
                    }
                }



                if (inventoryManege == "0")
                {
                    Console.Clear();
                    wrong = "";
                    InventoryScene();
                }
                else if (inventoryManege == "1")
                {
                    if (item1 == "Empty")
                    {
                        Console.Clear();
                        wrong = "비어있습니다.";
                        InventoryManegeScene();
                    }
                    else if (item1 != "Empty" && insert1 == "")
                    {
                        Console.Clear();                        
                        Insert1();
                        itemstat1();
                        wrong = "장착되었습니다.";
                        InventoryManegeScene();

                    }
                    else
                    {
                        Console.Clear();
                        Insert1();
                        itemstatM1();
                        wrong = "해제되었습니다.";
                        InventoryManegeScene();
                    }

                }
                else if (inventoryManege == "2")
                {
                    if (item2 == "Empty")
                    {
                        Console.Clear();
                        wrong = "비어있습니다.";
                        InventoryManegeScene();
                    }
                    else if (item2 != "Empty" && insert2 == "")
                    {
                        Console.Clear();
                        Insert2();
                        itemstat2();
                        wrong = "장착되었습니다.";
                        InventoryManegeScene();

                    }
                    else
                    {
                        Console.Clear();
                        Insert2();
                        itemstatM2();
                        wrong = "해제되었습니다.";
                        InventoryManegeScene();
                    }
                }
                else if (inventoryManege == "3")
                {
                    if (item3 == "Empty")
                    {
                        Console.Clear();
                        wrong = "비어있습니다.";
                        InventoryManegeScene();
                    }
                    else if (item3 != "Empty" && insert3 == "")
                    {
                        Console.Clear();
                        Insert3();
                        itemstat3();
                        wrong = "장착되었습니다.";
                        InventoryManegeScene();

                    }
                    else
                    {
                        Console.Clear();
                        Insert3();
                        itemstatM3();
                        wrong = "해제되었습니다.";
                        InventoryManegeScene();
                    }
                }
                else if (inventoryManege == "4")
                {
                    if (item4 == "Empty")
                    {
                        Console.Clear();
                        wrong = "비어있습니다.";
                        InventoryManegeScene();
                    }
                    else if (item4 != "Empty" && insert4 == "")
                    {
                        Console.Clear();
                        Insert4();
                        itemstat4();
                        wrong = "장착되었습니다.";
                        InventoryManegeScene();

                    }
                    else
                    {
                        Console.Clear();
                        Insert4();
                        itemstatM4();
                        wrong = "해제되었습니다.";
                        InventoryManegeScene();
                    }
                }
                else if (inventoryManege == "5")
                {
                    if (item5 == "Empty")
                    {
                        Console.Clear();
                        wrong = "비어있습니다.";
                        InventoryManegeScene();
                    }
                    else if (item5 != "Empty" && insert5 == "")
                    {
                        Console.Clear();
                        Insert5();
                        itemstat5();
                        wrong = "장착되었습니다.";
                        InventoryManegeScene();

                    }
                    else
                    {
                        Console.Clear();
                        Insert5();
                        itemstatM5();
                        wrong = "해제되었습니다.";
                        InventoryManegeScene();
                    }
                }
                else
                {
                    Console.Clear();
                    wrong = "잘못된 입력입니다.";
                    InventoryManegeScene();
                }
            }




            void StoreScene()
            {
                Console.WriteLine("상점");
                Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.");
                Console.WriteLine("\n");
                Console.WriteLine("[보유 골드]");
                Console.WriteLine("{0} G", chartor.gold);
                Console.WriteLine("\n");
                Console.WriteLine("[아이템 목록]");
                Console.WriteLine("- 수련자 갑옷   / 방어력 +5  / 수련에 도움을 주는 갑옷입니다.                  / {0} ", itemBuy1);
                Console.WriteLine("- 무쇠 갑옷     / 방어력 +9  / 무쇠로 만들어져 튼튼한 갑옷입니다.              / {0} ", itemBuy2);
                Console.WriteLine("- 스파르타 갑옷 / 방어력 +15 / 스파르타 전사들이 사용했다는 전설의 갑옷입니다. / {0} ", itemBuy3);
                Console.WriteLine("- 낡은 검       / 공격력 +2  / 쉽게 볼 수 있는 낡은 검입니다.                  / {0} ", itemBuy4);
                Console.WriteLine("- 청동 도끼     / 공격력 +5  / 어디선가 사용됐던거 같은 도끼입니다.            / {0} ", itemBuy5);
                Console.WriteLine("- 스파르타 창   / 공격력 +7  / 스파르타 전사들이 사용했다는 전설의 창입니다.   / {0} ", itemBuy6);
                Console.WriteLine("- 용사의 검   / 공격력 +15  / 세상을 구할 용사들이 사용했다는 전설의 검입니다. / {0} ", itemBuy7);
                Console.WriteLine("\n");
                Console.WriteLine("1. 아이템 구매");
                Console.WriteLine("0. 나가기");
                Console.WriteLine("\n");
                Console.Write("원하시는 행동을 입력해주세요. : {0}", wrong);

                string store = Console.ReadLine();

                if (store == "0")
                {
                    Console.Clear();
                    wrong = "";
                    MainScene();
                }
                else if (store == "1")
                {
                    Console.Clear();
                    wrong = "";
                    StoreBuyScene();
                }
                else
                {
                    Console.Clear();
                    wrong = "잘못된 입력입니다.";
                    StoreScene();
                }
            }


            void StoreBuyScene()
            {
                Console.WriteLine("상점 - 아이템 구매");
                Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.");
                Console.WriteLine("\n");
                Console.WriteLine("[보유 골드]");
                Console.WriteLine("{0} G", chartor.gold);
                Console.WriteLine("\n");
                Console.WriteLine("[아이템 목록]");
                Console.WriteLine("- 1 수련자 갑옷   / 방어력 +5  / 수련에 도움을 주는 갑옷입니다.                  / {0} ", itemBuy1);
                Console.WriteLine("- 2 무쇠 갑옷     / 방어력 +9  / 무쇠로 만들어져 튼튼한 갑옷입니다.              / {0} ", itemBuy2);
                Console.WriteLine("- 3 스파르타 갑옷 / 방어력 +15 / 스파르타 전사들이 사용했다는 전설의 갑옷입니다. / {0} ", itemBuy3);
                Console.WriteLine("- 4 낡은 검       / 공격력 +2  / 쉽게 볼 수 있는 낡은 검입니다.                  / {0} ", itemBuy4);
                Console.WriteLine("- 5 청동 도끼     / 공격력 +5  / 어디선가 사용됐던거 같은 도끼입니다.            / {0} ", itemBuy5);
                Console.WriteLine("- 6 스파르타 창   / 공격력 +7  / 스파르타 전사들이 사용했다는 전설의 창입니다.   / {0} ", itemBuy6);
                Console.WriteLine("- 7 용사의 검   / 공격력 +15  / 세상을 구할 용사들이 사용했다는 전설의 검입니다. / {0} ", itemBuy7);
                Console.WriteLine("\n");
                Console.WriteLine("0. 나가기");
                Console.WriteLine("\n");
                Console.Write("원하시는 행동을 입력해주세요. : {0}", wrong);

                string storeBuy = Console.ReadLine();
               

                bool isfull1 = item1 == "Empty";
                bool isfull2 = item2 == "Empty";
                bool isfull3 = item3 == "Empty";
                bool isfull4 = item4 == "Empty";
                bool isfull5 = item5 == "Empty";


                if (storeBuy == "0")
                {
                    Console.Clear();
                    wrong = "";
                    StoreScene();
                }
                else if (storeBuy == "1")
                {
                    if (itemBuy1 == "구매 완료")
                    {
                        Console.Clear();
                        wrong = "이미 구매한 아이템입니다.";
                        StoreBuyScene();
                    }
                    else
                    {
                        Isfull2();
                        itemBuy1 = "구매 완료";
                        Isfull();
                        Spend(1000);

                    }

                }
                else if (storeBuy == "2")
                {
                    if (itemBuy2 == "구매 완료")
                    {
                        Console.Clear();
                        wrong = "이미 구매한 아이템입니다.";
                        StoreBuyScene();
                    }
                    else
                    {
                        Isfull2();
                        itemBuy2 = "구매 완료";
                        Isfull();
                        Spend(1500);
                    }
                }
                else if (storeBuy == "3")
                {
                    if (itemBuy3 == "구매 완료")
                    {
                        Console.Clear();
                        wrong = "이미 구매한 아이템입니다.";
                        StoreBuyScene();
                    }
                    else
                    {
                        Isfull2();
                        itemBuy3 = "구매 완료";
                        Isfull();
                        Spend(3500);
                    }
                }
                else if (storeBuy == "4")
                {
                    if (itemBuy4 == "구매 완료")
                    {
                        Console.Clear();
                        wrong = "이미 구매한 아이템입니다.";
                        StoreBuyScene();
                    }
                    else
                    {
                        Isfull2();
                        itemBuy4 = "구매 완료";
                        Isfull();
                        Spend(600);
                    }
                }
                else if (storeBuy == "5")
                {
                    if (itemBuy5 == "구매 완료")
                    {
                        Console.Clear();
                        wrong = "이미 구매한 아이템입니다.";
                        StoreBuyScene();
                    }
                    else
                    {
                        Isfull2();
                        itemBuy5 = "구매 완료";
                        Isfull();
                        Spend(1500);
                    }
                }
                else if (storeBuy == "6")
                {
                    if (itemBuy6 == "구매 완료")
                    {
                        Console.Clear();
                        wrong = "이미 구매한 아이템입니다.";
                        StoreBuyScene();
                    }
                    else
                    {
                        Isfull2();
                        itemBuy6 = "구매 완료";
                        Isfull();
                        Spend(3500);
                    }
                }
                else if (storeBuy == "7")
                {
                    if (itemBuy7 == "구매 완료")
                    {
                        Console.Clear();
                        wrong = "이미 구매한 아이템입니다.";
                        StoreBuyScene();
                    }
                    else
                    {
                        Isfull2();
                        itemBuy7 = "구매 완료";
                        Isfull();
                        Spend(7500);
                    }

                }
                else
                {
                    Console.Clear();
                    wrong = "잘못된 입력입니다.";
                    StoreBuyScene();
                }


                void Isfull()
                {
                    int num = int.Parse(storeBuy);

                    if (isfull1)
                    {
                        item1 = item[num - 1];
                    }
                    else if (isfull2)
                    {
                        item2 = item[num - 1];
                    }
                    else if (isfull3)
                    {
                        item3 = item[num - 1];
                    }
                    else if (isfull4)
                    {
                        item4 = item[num - 1];
                    }
                    else if (isfull5)
                    {
                        item5 = item[num - 1];
                    }
                    else
                    {
                        Console.Clear();
                        wrong = "인벤토리가 꽉 찼습니다.";
                        StoreBuyScene();
                    }
                }

                void Isfull2()
                {
                    if (!isfull1 && !isfull2 && !isfull3 && !isfull4 && !isfull5)
                    {
                        Console.Clear();
                        wrong = "인벤토리가 꽉 찼습니다.";
                        StoreBuyScene();
                    }
                    return;
                }

            }


            void Spend(int cost)
            {
                if (cost > chartor.gold)
                {
                    Console.Clear();
                    wrong = "골드가 부족합니다.";
                    StoreBuyScene();
                }
                else
                {
                    Console.Clear();
                    wrong = "성공적으로 구매하였습니다.";
                    chartor.gold -= cost;
                    StoreBuyScene();
                }

            }

            void itemstat1()
            {
                if (insert1 == "[E]" && item1 == item[0])
                {
                    chartor.dp += 5;
                }
                else if (insert1 == "[E]" && item1 == item[1])
                {
                    chartor.dp += 9;
                }
                else if (insert1 == "[E]" && item1 == item[2])
                {
                    chartor.dp += 12;
                }
                else if (insert1 == "[E]" && item1 == item[3])
                {
                    chartor.op += 2;
                }
                else if (insert1 == "[E]" && item1 == item[4])
                {
                    chartor.op += 5;
                }
                else if (insert1 == "[E]" && item1 == item[5])
                {
                    chartor.op += 7;
                }
                else if (insert1 == "[E]" && item1 == item[6])
                {
                    chartor.op += 15;
                }
            }

                void itemstat2()
            {

                if (insert2 == "[E]" && item2 == item[0])
                {
                    chartor.dp += 5;
                }
                else if (insert2 == "[E]" && item2 == item[1])
                {
                    chartor.dp += 9;
                }
                else if (insert2 == "[E]" && item2 == item[2])
                {
                    chartor.dp += 12;
                }
                else if (insert2 == "[E]" && item2 == item[3])
                {
                    chartor.op += 2;
                }
                else if (insert2 == "[E]" && item2 == item[4])
                {
                    chartor.op += 5;
                }
                else if (insert2 == "[E]" && item2 == item[5])
                {
                    chartor.op += 7;
                }
                else if (insert2 == "[E]" && item2 == item[6])
                {
                    chartor.op += 15;
                }
            }

                void itemstat3()
                {

                    if (insert3 == "[E]" && item3 == item[0])
                    {
                        chartor.dp += 5;
                    }
                    else if (insert3 == "[E]" && item3 == item[1])
                    {
                        chartor.dp += 9;
                    }
                    else if (insert3 == "[E]" && item3 == item[2])
                    {
                        chartor.dp += 12;
                    }
                    else if (insert3 == "[E]" && item3 == item[3])
                    {
                        chartor.op += 2;
                    }
                    else if (insert3 == "[E]" && item3 == item[4])
                    {
                        chartor.op += 5;
                    }
                    else if (insert3 == "[E]" && item3 == item[5])
                    {
                        chartor.op += 7;
                    }
                    else if (insert3 == "[E]" && item3 == item[6])
                    {
                        chartor.op += 15;
                    }
                }

                void itemstat4()
                {

                    if (insert4 == "[E]" && item4 == item[0])
                    {
                        chartor.dp += 5;
                    }
                    else if (insert4 == "[E]" && item4 == item[1])
                    {
                        chartor.dp += 9;
                    }
                    else if (insert4 == "[E]" && item4 == item[2])
                    {
                        chartor.dp += 12;
                    }
                    else if (insert4 == "[E]" && item4 == item[3])
                    {
                        chartor.op += 2;
                    }
                    else if (insert4 == "[E]" && item4 == item[4])
                    {
                        chartor.op += 5;
                    }
                    else if (insert4 == "[E]" && item4 == item[5])
                    {
                        chartor.op += 7;
                    }
                    else if (insert4 == "[E]" && item4 == item[6])
                    {
                        chartor.op += 15;
                    }   

                }

                void itemstat5()
                {

                    if (insert5 == "[E]" && item5 == item[0])
                    {
                        chartor.dp += 5;
                    }
                    else if (insert5 == "[E]" && item5 == item[1])
                    {
                        chartor.dp += 9;
                    }
                    else if (insert5 == "[E]" && item5 == item[2])
                    {
                        chartor.dp += 12;
                    }
                    else if (insert5 == "[E]" && item5 == item[3])
                    {
                        chartor.op += 2;
                    }
                    else if (insert5 == "[E]" && item5 == item[4])
                    {
                        chartor.op += 5;
                    }
                    else if (insert5 == "[E]" && item5 == item[5])
                    {
                        chartor.op += 7;
                    }
                    else if (insert5 == "[E]" && item5 == item[6])
                    {
                        chartor.op += 15;
                    }

            }


                void itemstatM1()
                {
                    if (insert1 != "[E]" && item1 == item[0])
                    {
                        chartor.dp -= 5;
                    }
                    else if (insert1 != "[E]" && item1 == item[1])
                    {
                        chartor.dp -= 9;
                    }
                    else if (insert1 != "[E]" && item1 == item[2])
                    {
                        chartor.dp -= 12;
                    }
                    else if (insert1 != "[E]" && item1 == item[3])
                    {
                        chartor.op -= 2;
                    }
                    else if (insert1 != "[E]" && item1 == item[4])
                    {
                        chartor.op -= 5;
                    }
                    else if (insert1 != "[E]" && item1 == item[5])
                    {
                        chartor.op -= 7;
                    }
                    else if (insert1 != "[E]" && item1 == item[6])
                    {
                        chartor.op -= 15;
                    }
                }

                void itemstatM2()
                {

                    if (insert2 != "[E]" && item2 == item[0])
                    {
                        chartor.dp -= 5;
                    }
                    else if (insert2 != "[E]" && item2 == item[1])
                    {
                        chartor.dp -= 9;
                    }
                    else if (insert2 != "[E]" && item2 == item[2])
                    {
                        chartor.dp -= 12;
                    }
                    else if (insert2 != "[E]" && item2 == item[3])
                    {
                        chartor.op -= 2;
                    }
                    else if (insert2 != "[E]" && item2 == item[4])
                    {
                        chartor.op -= 5;
                    }
                    else if (insert2 != "[E]" && item2 == item[5])
                    {
                        chartor.op -= 7;
                    }
                else if (insert2 != "[E]" && item2 == item[6])
                {
                    chartor.op -= 15;
                }
            }

                    void itemstatM3()
                    {

                        if (insert3 != "[E]" && item3 == item[0])
                        {
                            chartor.dp -= 5;
                        }
                        else if (insert3 != "[E]" && item3 == item[1])
                        {
                            chartor.dp -= 9;
                        }
                        else if (insert3 != "[E]" && item3 == item[2])
                        {
                            chartor.dp -= 12;
                        }
                        else if (insert3 != "[E]" && item3 == item[3])
                        {
                            chartor.op -= 2;
                        }
                        else if (insert3 != "[E]" && item3 == item[4])
                        {
                            chartor.op -= 5;
                        }
                        else if (insert3 != "[E]" && item3 == item[5])
                        {
                            chartor.op -= 7;
                        }
                else if (insert3 != "[E]" && item3 == item[6])
                {
                    chartor.op -= 15;
                }
            }

                    void itemstatM4()
                    {

                        if (insert4 != "[E]" && item4 == item[0])
                        {
                            chartor.dp -= 5;
                        }
                        else if (insert4 != "[E]" && item4 == item[1])
                        {
                            chartor.dp -= 9;
                        }
                        else if (insert4 != "[E]" && item4 == item[2])
                        {
                            chartor.dp -= 12;
                        }
                        else if (insert4 != "[E]" && item4 == item[3])
                        {
                            chartor.op -= 2;
                        }
                        else if (insert4 != "[E]" && item4 == item[4])
                        {
                            chartor.op -= 5;
                        }
                        else if (insert4 != "[E]" && item4 == item[5])
                        {
                            chartor.op -= 7;
                        }
                else if (insert4 != "[E]" && item4 == item[6])
                {
                    chartor.op -= 15;
                }

            }

                    void itemstatM5()
                    {

                        if (insert5 != "[E]" && item5 == item[0])
                        {
                            chartor.dp -= 5;
                        }
                        else if (insert5 != "[E]" && item5 == item[1])
                        {
                            chartor.dp -= 9;
                        }
                        else if (insert5 != "[E]" && item5 == item[2])
                        {
                            chartor.dp -= 12;
                        }
                        else if (insert5 != "[E]" && item5 == item[3])
                        {
                            chartor.op -= 2;
                        }
                        else if (insert5 != "[E]" && item5 == item[4])
                        {
                            chartor.op -= 5;
                        }
                        else if (insert5 != "[E]" && item5 == item[5])
                        {
                            chartor.op -= 7;
                        }
                else if (insert5 != "[E]" && item5 == item[6])
                {
                    chartor.op -= 15;
                }
            }
                }




        }
}


