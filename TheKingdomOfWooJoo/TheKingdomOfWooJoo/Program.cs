using System;

namespace GameTest1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("우주의나라 테스터로 참여해 주셔서 감사합니다");
            Console.WriteLine("");
            Console.WriteLine("당신이 지급 받은 키 값입니다");
            Console.WriteLine("ID : Yoonwoojoo              Password : 123");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            string id = "Yoonwoojoo";
            string password = "123";
            bool logIn = true; // TIL


            while (logIn) // TIL
            {
                Console.WriteLine("아이디를 입력해 주세요.");
                string inputId = Console.ReadLine();
                Console.WriteLine("비밀번호를 입력해 주세요.");
                string inputPassword = Console.ReadLine();
                Console.WriteLine("");


                if (inputId == id && inputPassword == password)
                {
                    Console.WriteLine("로그인에 성공하였습니다");
                    logIn = false;
                    LoadScene();
                }
                else
                {
                    Console.WriteLine("아이디 혹은 패스워드가 일치하지 않습니다.");
                    Console.WriteLine("다시 입력해 주세요.");
                    Console.WriteLine();
                }
            }
        }


        static public void LoadScene()
        {
            int eat = 0;
            int eat2 = 0;
            int eat3 = 0;
            string[] order = { "a. ", "b. ", "c. ", "d. ", "e. ", "f. ", "g. ", "h. ", "i. ", "j. ", "k. ", "l. ", "m. ", "n. ", "o. ", "p. ", "q. ", "r, ", "s. " };
            string[] equipmentNames = { "도토리", "타라의 남자옷", "사두목검", "녹용", "정화의 방패", "보라색여자갑주", "현철중검", "금장남자투구", "파란색비늘남자갑주", "심판의 낫", "사각방패", "보라색 반지", "보라색 반지", "용왕의 반지", "부여성 비서", "시력회복귀걸이", "목도", "장창", "도씨검" };
            bool[] isEquipped = new bool[order.Length];
            int?[] quantities = new int?[order.Length];
            string[] gae = new string[order.Length];
            int?[] x = new int?[order.Length]; // 무장 변수
            int?[] y = new int?[order.Length]; // 파괴력 변수
            int?[] z = new int?[order.Length]; // 요구레벨 변수
            string[] requireLevel = new string[order.Length];
            string[] ac = new string[order.Length];
            string[] dam = new string[order.Length];
            int gold = 500;

            order[16] = null;
            order[17] = null;
            order[18] = null;
            equipmentNames[16] = null;
            equipmentNames[17] = null;
            equipmentNames[18] = null;


            isEquipped[0] = false;

            Console.WriteLine("");
            Console.WriteLine("로딩 중");
            Console.WriteLine(".");
            Console.WriteLine("..");
            Console.WriteLine("...");
            Console.WriteLine("");
            WeaponPlace();
            GameScene(order, eat, equipmentNames, isEquipped, quantities, eat2, gae, eat3, x, y, z, requireLevel, ac, dam, gold);
        }

        static public void NoticePlace()
        {
            // 노티스플레이스의 초기값을 웨폰플레이스 해놓고

            // 부여성비서를 사용하면 노티스플레이스에서 주막플레이스로 옮겨야함
        }

        static public void WeaponPlace()
        {
            Console.WriteLine("");
            Console.WriteLine("                                                  이 곳은 [부여성 대장간] 입니다");
            Console.WriteLine("");
        }

        static public void JumakPlace()
        {
            Console.WriteLine("");
            Console.WriteLine("                                                  이 곳은 [연실이네 주막] 입니다");
            Console.WriteLine("");
        }

        static public void GameScene(string[] order, int eat, string[] equipmentNames, bool[] isEquipped, int?[] quantities, int eat2, string[] gae, int eat3, int?[] x, int?[] y, int?[] z, string[] requireLevel, string[] ac, string[] dam, int gold)
        {
            Console.WriteLine("");
            Console.WriteLine("원하는 기능을 선택하세요");
            Console.WriteLine("");
            Console.WriteLine("[1] 캐릭터 정보");
            Console.WriteLine("[2] 인벤토리 확인");
            Console.WriteLine("[3] 털보 NPC를 클릭하기");
            Console.WriteLine("");
            string input = Console.ReadLine();

            if (input == "1")
            {
                Stats(order, eat, equipmentNames, isEquipped, quantities, eat2, gae, eat3, x, y, z, requireLevel, ac, dam, gold);
            }
            else if (input == "2")
            {
                Inventory(order, eat, equipmentNames, isEquipped, quantities, eat2, gae, eat3, x, y, z, requireLevel, ac, dam, gold);
            }
            else if (input == "3")
            {
                TerboNPC(order, eat, equipmentNames, isEquipped, quantities, eat2, gae, eat3, x, y, z, requireLevel, ac, dam, gold);
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("잘못된 입력입니다");
                GameScene(order, eat, equipmentNames, isEquipped, quantities, eat2, gae, eat3, x, y, z, requireLevel, ac, dam, gold);
            }
        }

        static public void GameScene2(string[] order, int eat, string[] equipmentNames, bool[] isEquipped, int?[] quantities, int eat2, string[] gae, int eat3, int?[] x, int?[] y, int?[] z, string[] requireLevel, string[] ac, string[] dam, int gold)
        {
            Console.WriteLine("");
            Console.WriteLine("원하는 기능을 선택하세요");
            Console.WriteLine("");
            Console.WriteLine("[1] 캐릭터 정보");
            Console.WriteLine("[2] 인벤토리 확인");
            Console.WriteLine("[3] 대장간으로 가기");
            Console.WriteLine("");
            string input = Console.ReadLine();

            if (input == "1")
            {
                Stats(order, eat, equipmentNames, isEquipped, quantities, eat2, gae, eat3, x, y, z, requireLevel, ac, dam, gold);
            }
            else if (input == "2")
            {
                Inventory2(order, eat, equipmentNames, isEquipped, quantities, eat2, gae, eat3, x, y, z, requireLevel, ac, dam, gold);
            }
            else if (input == "3")
            {
                WeaponPlace();
                GameScene(order, eat, equipmentNames, isEquipped, quantities, eat2, gae, eat3, x, y, z, requireLevel, ac, dam, gold);
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("잘못된 입력입니다");
                GameScene2(order, eat, equipmentNames, isEquipped, quantities, eat2, gae, eat3, x, y, z, requireLevel, ac, dam, gold);
            }
        }

        static public void Stats(string[] order, int eat, string[] equipmentNames, bool[] isEquipped, int?[] quantities, int eat2, string[] gae, int eat3, int?[] x, int?[] y, int?[] z, string[] requireLevel, string[] ac, string[] dam, int gold)
        {

            Console.WriteLine("");
            Console.WriteLine("  < Stats >");
            Console.WriteLine("");
            Console.WriteLine("   히무라");
            Console.WriteLine("  전사(♂)"); // 성별은 남자
            Console.WriteLine("");
            Console.WriteLine("  레벨  44");
            Console.WriteLine("  힘    44");
            Console.WriteLine("  민첩  21");
            Console.WriteLine("  지식  21");
            Console.WriteLine("");


            int totalEquipmentBonus = 0;
            int totalDamageBonus = 20;

            // 장착된 아이템의 무장과 파괴력 값을 누적
            for (int i = 0; i < equipmentNames.Length; i++)
            {
                if (isEquipped[i])
                {
                    totalEquipmentBonus += x[i] ?? 0; // 무장 값
                    totalDamageBonus += y[i] ?? 0; // 파괴력 값
                }
            }

            Console.WriteLine("  무장 " + totalEquipmentBonus + " (" + totalEquipmentBonus + ")");
            Console.WriteLine("  파괴력 " + totalDamageBonus + " (+" + (totalDamageBonus - 20) + ")");
            Console.WriteLine("");
            Console.WriteLine("  체력   2145/2145");
            Console.WriteLine("  마력   350/487");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("  [back] 돌아 가기");
            Console.WriteLine("");

            string input = Console.ReadLine();
            if (input == "back")
            {
                GameScene(order, eat, equipmentNames, isEquipped, quantities, eat2, gae, eat3, x, y, z, requireLevel, ac, dam, gold);
            }
            else
            {
                Stats(order, eat, equipmentNames, isEquipped, quantities, eat2, gae, eat3, x, y, z, requireLevel, ac, dam, gold);
            }
        }
        static public void Inventory(string[] order, int eat, string[] equipmentNames, bool[] isEquipped, int?[] quantities, int eat2, string[] gae, int eat3, int?[] x, int?[] y, int?[] z, string[] requireLevel, string[] ac, string[] dam, int gold)
        {
            quantities[0] = 201 - eat;
            gae[0] = "개";
            quantities[3] = 17 - eat2;
            gae[3] = "개";
            quantities[14] = 31 - eat3;
            gae[14] = "개";

            requireLevel[1] = "     ||       랩제 = ";
            z[1] = 56;
            requireLevel[2] = "          ||       힘제 = ";
            z[2] = 17;
            requireLevel[4] = "       ||       랩제 = ";
            z[4] = 50;
            requireLevel[5] = "    ||       랩제 = ";
            z[5] = 16;
            requireLevel[6] = "          || (전사 전용) 힘제 = ";
            z[6] = 40;
            requireLevel[7] = "      ||       랩제 = ";
            z[7] = 0;
            requireLevel[8] = "||       랩제 = ";
            z[8] = 26;
            requireLevel[9] = "         ||       랩제 = ";
            z[9] = 99;
            requireLevel[10] = "          || (전사 전용) 랩제 = ";
            z[10] = 20;
            requireLevel[11] = "       ||       랩제 = ";
            z[11] = 15;
            requireLevel[12] = "       ||       랩제 = ";
            z[12] = 15;
            requireLevel[13] = "       ||       랩제 = ";
            z[13] = 90;
            requireLevel[15] = "    ||       랩제 = ";
            z[15] = 0;

            x[0] = null;
            ac[1] = "       ||   무장";
            x[1] = -28;
            x[2] = null;
            x[3] = null;
            ac[4] = "       ||   무장";
            x[4] = -7;
            ac[5] = "       ||   무장";
            x[5] = -19;
            x[6] = null;
            ac[7] = "        ||   무장";
            x[7] = -10;
            ac[8] = "       ||   무장";
            x[8] = -26;
            x[9] = null;
            ac[10] = " ||   무장";
            x[10] = -3;
            ac[11] = "       ||   무장";
            x[11] = -5;
            ac[12] = "       ||   무장";
            x[12] = -5;
            ac[13] = "       ||   무장";
            x[13] = -9;
            x[14] = null;
            ac[15] = "        ||   무장";
            x[15] = -0;

            dam[2] = "      ||   파괴력";
            y[2] = 20;
            dam[6] = "||   파괴력";
            y[6] = 60;
            dam[9] = "      ||   파괴력";
            y[9] = 940;

            Console.WriteLine("");
            Console.WriteLine("  < Inventory >");
            Console.WriteLine("");

            // 각 장비에 대한 정보 출력
            for (int i = 0; i < order.Length; i++)
            {
                Console.WriteLine($" {order[i]} {equipmentNames[i]} {quantities[i]} {gae[i]} {requireLevel[i]} {z[i]} {ac[i]} " + $"{x[i]}" + $"{dam[i]}" + $"{y[i]}" + "  " + $"{(isEquipped[i] ? "[E]" : "")}"); // TIL
            }

            Console.WriteLine("");
            Console.WriteLine("  사용할 아이템의 알파벳을 입력하세요");
            Console.WriteLine("");
            Console.WriteLine("  [back] 돌아 가기");
            Console.WriteLine("");

            string input = Console.ReadLine();
            if (input == "back")
            {
                GameScene(order, eat, equipmentNames, isEquipped, quantities, eat2, gae, eat3, x, y, z, requireLevel, ac, dam, gold);
            }
            else if (input == "a")
            {
                eat += 1; // TIL eat=1;
                Console.WriteLine("");
                Console.WriteLine("                                                  ooo 도토리를 먹었습니다 ooo");
                Console.WriteLine("");
                Inventory(order, eat, equipmentNames, isEquipped, quantities, eat2, gae, eat3, x, y, z, requireLevel, ac, dam, gold);
            }
            else if (input == "b")
            {
                Console.WriteLine("");
                Console.WriteLine("                                                  xxx 아직은 사용할 수 없습니다 xxx");
                Console.WriteLine("");
                Inventory(order, eat, equipmentNames, isEquipped, quantities, eat2, gae, eat3, x, y, z, requireLevel, ac, dam, gold);
            }
            else if (input == "c")
            {
                if (isEquipped[2] == false)
                {
                    Console.WriteLine("");
                    Console.WriteLine("                                              ooo 사두목검을 장착하였습니다 ooo");
                    Console.WriteLine("");
                    isEquipped[2] = true;
                    isEquipped[6] = false;
                    isEquipped[16] = false;
                    isEquipped[17] = false;
                    isEquipped[18] = false;

                    Inventory(order, eat, equipmentNames, isEquipped, quantities, eat2, gae, eat3, x, y, z, requireLevel, ac, dam, gold);
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("                                              xxx 사두목검을 해제하였습니다 xxx");
                    Console.WriteLine("");
                    isEquipped[2] = false;
                    isEquipped[6] = false;
                    isEquipped[16] = false;
                    isEquipped[17] = false;
                    isEquipped[18] = false;

                    Inventory(order, eat, equipmentNames, isEquipped, quantities, eat2, gae, eat3, x, y, z, requireLevel, ac, dam, gold);
                }
            }
            else if (input == "d")
            {
                eat2 += 1;
                Console.WriteLine("");
                Console.WriteLine("                                                  ooo 녹용을 먹었습니다 ooo");
                Console.WriteLine("");
                Inventory(order, eat, equipmentNames, isEquipped, quantities, eat2, gae, eat3, x, y, z, requireLevel, ac, dam, gold);
            }
            else if (input == "e")
            {
                Console.WriteLine("");
                Console.WriteLine("                                                  xxx 아직은 사용할 수 없습니다 xxx");
                Console.WriteLine("");
                Inventory(order, eat, equipmentNames, isEquipped, quantities, eat2, gae, eat3, x, y, z, requireLevel, ac, dam, gold);
            }
            else if (input == "f")
            {
                Console.WriteLine("");
                Console.WriteLine("                                                  남자는 착용할 수 없습니다 ;ㅅ;");
                Console.WriteLine("");
                Inventory(order, eat, equipmentNames, isEquipped, quantities, eat2, gae, eat3, x, y, z, requireLevel, ac, dam, gold);
            }
            else if (input == "g")
            {
                if (isEquipped[6] == false)
                {
                    Console.WriteLine("");
                    Console.WriteLine("                                              ooo 현철중검을 장착하였습니다 ooo");
                    Console.WriteLine("");
                    isEquipped[6] = true;
                    isEquipped[2] = false;
                    isEquipped[16] = false;
                    isEquipped[17] = false;
                    isEquipped[18] = false;

                    Inventory(order, eat, equipmentNames, isEquipped, quantities, eat2, gae, eat3, x, y, z, requireLevel, ac, dam, gold);
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("                                              xxx 현철중검을 해제하였습니다 xxx");
                    Console.WriteLine("");
                    isEquipped[6] = false;
                    isEquipped[2] = false;
                    isEquipped[16] = false;
                    isEquipped[17] = false;
                    isEquipped[18] = false;

                    Inventory(order, eat, equipmentNames, isEquipped, quantities, eat2, gae, eat3, x, y, z, requireLevel, ac, dam, gold);
                }
            }
            else if (input == "h")
            {
                if (isEquipped[7] == false)
                {
                    Console.WriteLine("");
                    Console.WriteLine("                                              ooo 금장남자투구를 장착하였습니다 ooo");
                    Console.WriteLine("");
                    isEquipped[7] = true;

                    Inventory(order, eat, equipmentNames, isEquipped, quantities, eat2, gae, eat3, x, y, z, requireLevel, ac, dam, gold);
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("                                              xxx 금장남자투구를 해제하였습니다 xxx");
                    Console.WriteLine("");
                    isEquipped[7] = false;

                    Inventory(order, eat, equipmentNames, isEquipped, quantities, eat2, gae, eat3, x, y, z, requireLevel, ac, dam, gold);
                }
            }
            else if (input == "i")
            {
                if (isEquipped[8] == false)
                {

                    Console.WriteLine("");
                    Console.WriteLine("                                              ooo 파란색비늘남자갑주를 장착하였습니다 ooo");
                    Console.WriteLine("");
                    isEquipped[8] = true;

                    Inventory(order, eat, equipmentNames, isEquipped, quantities, eat2, gae, eat3, x, y, z, requireLevel, ac, dam, gold);
                }
                else
                {

                    Console.WriteLine("");
                    Console.WriteLine("                                              xxx 파란색비늘남자갑주를 해제하였습니다 xxx");
                    Console.WriteLine("");
                    isEquipped[8] = false;

                    Inventory(order, eat, equipmentNames, isEquipped, quantities, eat2, gae, eat3, x, y, z, requireLevel, ac, dam, gold);
                }
            }
            else if (input == "j")
            {
                Console.WriteLine("");
                Console.WriteLine("                                                  xxx 아직은 사용할 수 없습니다 xxx");
                Console.WriteLine("");
                Inventory(order, eat, equipmentNames, isEquipped, quantities, eat2, gae, eat3, x, y, z, requireLevel, ac, dam, gold);
            }
            else if (input == "k")
            {
                if (isEquipped[10] == false)
                {
                    Console.WriteLine("");
                    Console.WriteLine("                                              ooo 사각방패를 장착하였습니다 ooo");
                    Console.WriteLine("");
                    isEquipped[10] = true;
                    Inventory(order, eat, equipmentNames, isEquipped, quantities, eat2, gae, eat3, x, y, z, requireLevel, ac, dam, gold);
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("                                              xxx 사각방패를 해제하였습니다 xxx");
                    Console.WriteLine("");
                    isEquipped[10] = false;

                    Inventory(order, eat, equipmentNames, isEquipped, quantities, eat2, gae, eat3, x, y, z, requireLevel, ac, dam, gold);
                }
            }
            else if (input == "l")
            {
                if (isEquipped[11] == false)
                {

                    Console.WriteLine("");
                    Console.WriteLine("                                              ooo 보라색 반지를 장착하였습니다 ooo");
                    Console.WriteLine("");
                    isEquipped[11] = true;

                    Inventory(order, eat, equipmentNames, isEquipped, quantities, eat2, gae, eat3, x, y, z, requireLevel, ac, dam, gold);
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("                                              xxx 보라색 반지를 해제하였습니다 xxx");
                    Console.WriteLine("");
                    isEquipped[11] = false;

                    Inventory(order, eat, equipmentNames, isEquipped, quantities, eat2, gae, eat3, x, y, z, requireLevel, ac, dam, gold);
                }
            }
            else if (input == "m")
            {
                if (isEquipped[12] == false)
                {

                    Console.WriteLine("");
                    Console.WriteLine("                                              ooo 보라색 반지를 장착하였습니다 ooo");
                    Console.WriteLine("");
                    isEquipped[12] = true;

                    Inventory(order, eat, equipmentNames, isEquipped, quantities, eat2, gae, eat3, x, y, z, requireLevel, ac, dam, gold);
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("                                              xxx 보라색 반지를 해제하였습니다 xxx");
                    Console.WriteLine("");
                    isEquipped[12] = false;

                    Inventory(order, eat, equipmentNames, isEquipped, quantities, eat2, gae, eat3, x, y, z, requireLevel, ac, dam, gold);
                }
            }
            else if (input == "n")
            {
                Console.WriteLine("");
                Console.WriteLine("                                                  xxx 아직은 사용할 수 없습니다 xxx");
                Console.WriteLine("");
                Inventory(order, eat, equipmentNames, isEquipped, quantities, eat2, gae, eat3, x, y, z, requireLevel, ac, dam, gold);
            }
            else if (input == "o")
            {
                eat3 += 1;
                Console.WriteLine("");
                Console.WriteLine("                                                  ... 부여성 비서를 사용합니다 ...");
                Console.WriteLine();
                JumakPlace();
                GameScene2(order, eat, equipmentNames, isEquipped, quantities, eat2, gae, eat3, x, y, z, requireLevel, ac, dam, gold);
            }
            else if (input == "p")
            {
                if (isEquipped[15] == false)
                {

                    Console.WriteLine("");
                    Console.WriteLine("                                              ooo 시력회복귀걸이를 장착하였습니다 ooo");
                    Console.WriteLine("");
                    isEquipped[15] = true;

                    Inventory(order, eat, equipmentNames, isEquipped, quantities, eat2, gae, eat3, x, y, z, requireLevel, ac, dam, gold);
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("                                              xxx 시력회복귀걸이를 해제하였습니다 xxx");
                    Console.WriteLine("");
                    isEquipped[15] = false;

                    Inventory(order, eat, equipmentNames, isEquipped, quantities, eat2, gae, eat3, x, y, z, requireLevel, ac, dam, gold);
                }
            }
            else if (input == "q")
            {
                if (isEquipped[16] == false)
                {
                    Console.WriteLine("");
                    Console.WriteLine("                                              ooo 목도를 장착하였습니다 ooo");
                    Console.WriteLine("");
                    isEquipped[16] = true;
                    isEquipped[2] = false;
                    isEquipped[6] = false;
                    isEquipped[17] = false;
                    isEquipped[18] = false;

                    Inventory(order, eat, equipmentNames, isEquipped, quantities, eat2, gae, eat3, x, y, z, requireLevel, ac, dam, gold);
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("                                              xxx 목도를 해제하였습니다 xxx");
                    Console.WriteLine("");
                    isEquipped[16] = false;
                    isEquipped[6] = false;
                    isEquipped[2] = false;
                    isEquipped[17] = false;
                    isEquipped[18] = false;

                    Inventory(order, eat, equipmentNames, isEquipped, quantities, eat2, gae, eat3, x, y, z, requireLevel, ac, dam, gold);
                }
            }
            else if (input == "r")
            {
                if (isEquipped[17] == false)
                {
                    Console.WriteLine("");
                    Console.WriteLine("                                              ooo 장창을 장착하였습니다 ooo");
                    Console.WriteLine("");
                    isEquipped[17] = true;
                    isEquipped[2] = false;
                    isEquipped[6] = false;
                    isEquipped[16] = false;
                    isEquipped[18] = false;

                    Inventory(order, eat, equipmentNames, isEquipped, quantities, eat2, gae, eat3, x, y, z, requireLevel, ac, dam, gold);
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("                                              xxx 장창을 해제하였습니다 xxx");
                    Console.WriteLine("");
                    isEquipped[17] = false;
                    isEquipped[6] = false;
                    isEquipped[2] = false;
                    isEquipped[16] = false;
                    Inventory(order, eat, equipmentNames, isEquipped, quantities, eat2, gae, eat3, x, y, z, requireLevel, ac, dam, gold);
                }
            }
            else if (input == "s")
            {
                if (isEquipped[18] == false)
                {
                    Console.WriteLine("");
                    Console.WriteLine("                                              ooo 도씨검을 장착하였습니다 ooo");
                    Console.WriteLine("");
                    isEquipped[18] = true;
                    isEquipped[2] = false;
                    isEquipped[6] = false;
                    isEquipped[16] = false;
                    isEquipped[17] = false;

                    Inventory(order, eat, equipmentNames, isEquipped, quantities, eat2, gae, eat3, x, y, z, requireLevel, ac, dam, gold);
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("                                              xxx 도씨검을 해제하였습니다 xxx");
                    Console.WriteLine("");
                    isEquipped[18] = false;
                    isEquipped[6] = false;
                    isEquipped[2] = false;
                    isEquipped[16] = false;
                    isEquipped[17] = false;

                    Inventory(order, eat, equipmentNames, isEquipped, quantities, eat2, gae, eat3, x, y, z, requireLevel, ac, dam, gold);
                }
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("                                             그것은 인벤토리에 존재하지 않은 않는 아이템입니다.");
                Console.WriteLine("");
                Inventory(order, eat, equipmentNames, isEquipped, quantities, eat2, gae, eat3, x, y, z, requireLevel, ac, dam, gold);
            }
        }

        static public void Inventory2(string[] order, int eat, string[] equipmentNames, bool[] isEquipped, int?[] quantities, int eat2, string[] gae, int eat3, int?[] x, int?[] y, int?[] z, string[] requireLevel, string[] ac, string[] dam, int gold)
        {
            quantities[0] = 201 - eat;
            gae[0] = "개";
            quantities[3] = 17 - eat2;
            gae[3] = "개";
            quantities[14] = 31 - eat3;
            gae[14] = "개";

            requireLevel[1] = "     ||       랩제 = ";
            z[1] = 56;
            requireLevel[2] = "          ||       힘제 = ";
            z[2] = 17;
            requireLevel[4] = "       ||       랩제 = ";
            z[4] = 50;
            requireLevel[5] = "    ||       랩제 = ";
            z[5] = 16;
            requireLevel[6] = "          || (전사 전용) 힘제 = ";
            z[6] = 40;
            requireLevel[7] = "      ||       랩제 = ";
            z[7] = 0;
            requireLevel[8] = "||       랩제 = ";
            z[8] = 26;
            requireLevel[9] = "         ||       랩제 = ";
            z[9] = 99;
            requireLevel[10] = "          || (전사 전용) 랩제 = ";
            z[10] = 20;
            requireLevel[11] = "       ||       랩제 = ";
            z[11] = 15;
            requireLevel[12] = "       ||       랩제 = ";
            z[12] = 15;
            requireLevel[13] = "       ||       랩제 = ";
            z[13] = 90;
            requireLevel[15] = "    ||       랩제 = ";
            z[15] = 0;

            x[0] = null;
            ac[1] = "       ||   무장";
            x[1] = -28;
            x[2] = null;
            x[3] = null;
            ac[4] = "       ||   무장";
            x[4] = -7;
            ac[5] = "       ||   무장";
            x[5] = -19;
            x[6] = null;
            ac[7] = "        ||   무장";
            x[7] = -10;
            ac[8] = "       ||   무장";
            x[8] = -26;
            x[9] = null;
            ac[10] = " ||   무장";
            x[10] = -3;
            ac[11] = "       ||   무장";
            x[11] = -5;
            ac[12] = "       ||   무장";
            x[12] = -5;
            ac[13] = "       ||   무장";
            x[13] = -9;
            x[14] = null;
            ac[15] = "        ||   무장";
            x[15] = -0;

            dam[2] = "      ||   파괴력";
            y[2] = 20;
            dam[6] = "||   파괴력";
            y[6] = 60;
            dam[9] = "      ||   파괴력";
            y[9] = 940;

            Console.WriteLine("");
            Console.WriteLine("  < Inventory >");
            Console.WriteLine("");

            // 각 장비에 대한 정보 출력
            for (int i = 0; i < order.Length; i++)
            {
                Console.WriteLine($" {order[i]} {equipmentNames[i]} {quantities[i]} {gae[i]} {requireLevel[i]} {z[i]} {ac[i]} " + $"{x[i]}" + $"{dam[i]}" + $"{y[i]}" + "  " + $"{(isEquipped[i] ? "[E]" : "")}"); // TIL
            }

            Console.WriteLine("");
            Console.WriteLine("  사용할 아이템의 알파벳을 입력하세요");
            Console.WriteLine("");
            Console.WriteLine("  [back] 돌아 가기");
            Console.WriteLine("");

            string input = Console.ReadLine();
            if (input == "back")
            {
                GameScene2(order, eat, equipmentNames, isEquipped, quantities, eat2, gae, eat3, x, y, z, requireLevel, ac, dam, gold);
            }
            else if (input == "a")
            {
                eat += 1; // TIL eat=1;
                Console.WriteLine("");
                Console.WriteLine("                                                  ooo 도토리를 먹었습니다 ooo");
                Console.WriteLine("");
                Inventory2(order, eat, equipmentNames, isEquipped, quantities, eat2, gae, eat3, x, y, z, requireLevel, ac, dam, gold);
            }
            else if (input == "b")
            {
                Console.WriteLine("");
                Console.WriteLine("                                                  xxx 아직은 사용할 수 없습니다 xxx");
                Console.WriteLine("");
                Inventory2(order, eat, equipmentNames, isEquipped, quantities, eat2, gae, eat3, x, y, z, requireLevel, ac, dam, gold);
            }
            else if (input == "c")
            {
                if (isEquipped[2] == false)
                {
                    Console.WriteLine("");
                    Console.WriteLine("                                              ooo 사두목검을 장착하였습니다 ooo");
                    Console.WriteLine("");
                    isEquipped[2] = true;
                    isEquipped[6] = false;
                    isEquipped[16] = false;
                    isEquipped[17] = false;
                    isEquipped[18] = false;

                    Inventory2(order, eat, equipmentNames, isEquipped, quantities, eat2, gae, eat3, x, y, z, requireLevel, ac, dam, gold);
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("                                              xxx 사두목검을 해제하였습니다 xxx");
                    Console.WriteLine("");
                    isEquipped[2] = false;
                    isEquipped[6] = false;
                    isEquipped[16] = false;
                    isEquipped[17] = false;
                    isEquipped[18] = false;

                    Inventory2(order, eat, equipmentNames, isEquipped, quantities, eat2, gae, eat3, x, y, z, requireLevel, ac, dam, gold);
                }
            }
            else if (input == "d")
            {
                eat2 += 1;
                Console.WriteLine("");
                Console.WriteLine("                                                  ooo 녹용을 먹었습니다 ooo");
                Console.WriteLine("");
                Inventory2(order, eat, equipmentNames, isEquipped, quantities, eat2, gae, eat3, x, y, z, requireLevel, ac, dam, gold);
            }
            else if (input == "e")
            {
                Console.WriteLine("");
                Console.WriteLine("                                                  xxx 아직은 사용할 수 없습니다 xxx");
                Console.WriteLine("");
                Inventory2(order, eat, equipmentNames, isEquipped, quantities, eat2, gae, eat3, x, y, z, requireLevel, ac, dam, gold);
            }
            else if (input == "f")
            {
                Console.WriteLine("");
                Console.WriteLine("                                                  남자는 착용할 수 없습니다 ;ㅅ;");
                Console.WriteLine("");
                Inventory2(order, eat, equipmentNames, isEquipped, quantities, eat2, gae, eat3, x, y, z, requireLevel, ac, dam, gold);
            }
            else if (input == "g")
            {
                if (isEquipped[6] == false)
                {
                    Console.WriteLine("");
                    Console.WriteLine("                                              ooo 현철중검을 장착하였습니다 ooo");
                    Console.WriteLine("");
                    isEquipped[6] = true;
                    isEquipped[2] = false;
                    isEquipped[16] = false;
                    isEquipped[17] = false;
                    isEquipped[18] = false;

                    Inventory2(order, eat, equipmentNames, isEquipped, quantities, eat2, gae, eat3, x, y, z, requireLevel, ac, dam, gold);
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("                                              xxx 현철중검을 해제하였습니다 xxx");
                    Console.WriteLine("");
                    isEquipped[6] = false;
                    isEquipped[2] = false;
                    isEquipped[16] = false;
                    isEquipped[17] = false;
                    isEquipped[18] = false;

                    Inventory2(order, eat, equipmentNames, isEquipped, quantities, eat2, gae, eat3, x, y, z, requireLevel, ac, dam, gold);
                }
            }
            else if (input == "h")
            {
                if (isEquipped[7] == false)
                {
                    Console.WriteLine("");
                    Console.WriteLine("                                              ooo 금장남자투구를 장착하였습니다 ooo");
                    Console.WriteLine("");
                    isEquipped[7] = true;

                    Inventory2(order, eat, equipmentNames, isEquipped, quantities, eat2, gae, eat3, x, y, z, requireLevel, ac, dam, gold);
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("                                              xxx 금장남자투구를 해제하였습니다 xxx");
                    Console.WriteLine("");
                    isEquipped[7] = false;

                    Inventory2(order, eat, equipmentNames, isEquipped, quantities, eat2, gae, eat3, x, y, z, requireLevel, ac, dam, gold);
                }
            }
            else if (input == "i")
            {
                if (isEquipped[8] == false)
                {

                    Console.WriteLine("");
                    Console.WriteLine("                                              ooo 파란색비늘남자갑주를 장착하였습니다 ooo");
                    Console.WriteLine("");
                    isEquipped[8] = true;

                    Inventory2(order, eat, equipmentNames, isEquipped, quantities, eat2, gae, eat3, x, y, z, requireLevel, ac, dam, gold);
                }
                else
                {

                    Console.WriteLine("");
                    Console.WriteLine("                                              xxx 파란색비늘남자갑주를 해제하였습니다 xxx");
                    Console.WriteLine("");
                    isEquipped[8] = false;

                    Inventory2(order, eat, equipmentNames, isEquipped, quantities, eat2, gae, eat3, x, y, z, requireLevel, ac, dam, gold);
                }
            }
            else if (input == "j")
            {
                Console.WriteLine("");
                Console.WriteLine("                                                  xxx 아직은 사용할 수 없습니다 xxx");
                Console.WriteLine("");
                Inventory2(order, eat, equipmentNames, isEquipped, quantities, eat2, gae, eat3, x, y, z, requireLevel, ac, dam, gold);
            }
            else if (input == "k")
            {
                if (isEquipped[10] == false)
                {
                    Console.WriteLine("");
                    Console.WriteLine("                                              ooo 사각방패를 장착하였습니다 ooo");
                    Console.WriteLine("");
                    isEquipped[10] = true;
                    Inventory2(order, eat, equipmentNames, isEquipped, quantities, eat2, gae, eat3, x, y, z, requireLevel, ac, dam, gold);
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("                                              xxx 사각방패를 해제하였습니다 xxx");
                    Console.WriteLine("");
                    isEquipped[10] = false;

                    Inventory2(order, eat, equipmentNames, isEquipped, quantities, eat2, gae, eat3, x, y, z, requireLevel, ac, dam, gold);
                }
            }
            else if (input == "l")
            {
                if (isEquipped[11] == false)
                {

                    Console.WriteLine("");
                    Console.WriteLine("                                              ooo 보라색 반지를 장착하였습니다 ooo");
                    Console.WriteLine("");
                    isEquipped[11] = true;

                    Inventory2(order, eat, equipmentNames, isEquipped, quantities, eat2, gae, eat3, x, y, z, requireLevel, ac, dam, gold);
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("                                              xxx 보라색 반지를 해제하였습니다 xxx");
                    Console.WriteLine("");
                    isEquipped[11] = false;

                    Inventory2(order, eat, equipmentNames, isEquipped, quantities, eat2, gae, eat3, x, y, z, requireLevel, ac, dam, gold);
                }
            }
            else if (input == "m")
            {
                if (isEquipped[12] == false)
                {

                    Console.WriteLine("");
                    Console.WriteLine("                                              ooo 보라색 반지를 장착하였습니다 ooo");
                    Console.WriteLine("");
                    isEquipped[12] = true;

                    Inventory2(order, eat, equipmentNames, isEquipped, quantities, eat2, gae, eat3, x, y, z, requireLevel, ac, dam, gold);
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("                                              xxx 보라색 반지를 해제하였습니다 xxx");
                    Console.WriteLine("");
                    isEquipped[12] = false;

                    Inventory2(order, eat, equipmentNames, isEquipped, quantities, eat2, gae, eat3, x, y, z, requireLevel, ac, dam, gold);
                }
            }
            else if (input == "n")
            {
                Console.WriteLine("");
                Console.WriteLine("                                                  xxx 아직은 사용할 수 없습니다 xxx");
                Console.WriteLine("");
                Inventory2(order, eat, equipmentNames, isEquipped, quantities, eat2, gae, eat3, x, y, z, requireLevel, ac, dam, gold);
            }
            else if (input == "o")
            {
                eat3 += 1;
                Console.WriteLine("");
                Console.WriteLine("                                                  ... 부여성 비서를 사용합니다 ...");
                Console.WriteLine();
                JumakPlace();
                GameScene2(order, eat, equipmentNames, isEquipped, quantities, eat2, gae, eat3, x, y, z, requireLevel, ac, dam, gold);
            }
            else if (input == "p")
            {
                if (isEquipped[15] == false)
                {

                    Console.WriteLine("");
                    Console.WriteLine("                                              ooo 시력회복귀걸이를 장착하였습니다 ooo");
                    Console.WriteLine("");
                    isEquipped[15] = true;

                    Inventory2(order, eat, equipmentNames, isEquipped, quantities, eat2, gae, eat3, x, y, z, requireLevel, ac, dam, gold);
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("                                              xxx 시력회복귀걸이를 해제하였습니다 xxx");
                    Console.WriteLine("");
                    isEquipped[15] = false;

                    Inventory2(order, eat, equipmentNames, isEquipped, quantities, eat2, gae, eat3, x, y, z, requireLevel, ac, dam, gold);
                }
            }
            else if (input == "q")
            {
                if (isEquipped[16] == false)
                {
                    Console.WriteLine("");
                    Console.WriteLine("                                              ooo 목도를 장착하였습니다 ooo");
                    Console.WriteLine("");
                    isEquipped[16] = true;
                    isEquipped[2] = false;
                    isEquipped[6] = false;
                    isEquipped[17] = false;
                    isEquipped[18] = false;

                    Inventory(order, eat, equipmentNames, isEquipped, quantities, eat2, gae, eat3, x, y, z, requireLevel, ac, dam, gold);
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("                                              xxx 목도를 해제하였습니다 xxx");
                    Console.WriteLine("");
                    isEquipped[16] = false;
                    isEquipped[6] = false;
                    isEquipped[2] = false;
                    isEquipped[17] = false;
                    isEquipped[18] = false;

                    Inventory(order, eat, equipmentNames, isEquipped, quantities, eat2, gae, eat3, x, y, z, requireLevel, ac, dam, gold);
                }
            }
            else if (input == "r")
            {
                if (isEquipped[17] == false)
                {
                    Console.WriteLine("");
                    Console.WriteLine("                                              ooo 장창을 장착하였습니다 ooo");
                    Console.WriteLine("");
                    isEquipped[17] = true;
                    isEquipped[2] = false;
                    isEquipped[6] = false;
                    isEquipped[16] = false;
                    isEquipped[18] = false;

                    Inventory(order, eat, equipmentNames, isEquipped, quantities, eat2, gae, eat3, x, y, z, requireLevel, ac, dam, gold);
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("                                              xxx 장창을 해제하였습니다 xxx");
                    Console.WriteLine("");
                    isEquipped[17] = false;
                    isEquipped[6] = false;
                    isEquipped[2] = false;
                    isEquipped[16] = false;
                    Inventory(order, eat, equipmentNames, isEquipped, quantities, eat2, gae, eat3, x, y, z, requireLevel, ac, dam, gold);
                }
            }
            else if (input == "s")
            {
                if (isEquipped[18] == false)
                {
                    Console.WriteLine("");
                    Console.WriteLine("                                              ooo 도씨검을 장착하였습니다 ooo");
                    Console.WriteLine("");
                    isEquipped[18] = true;
                    isEquipped[2] = false;
                    isEquipped[6] = false;
                    isEquipped[16] = false;
                    isEquipped[17] = false;

                    Inventory(order, eat, equipmentNames, isEquipped, quantities, eat2, gae, eat3, x, y, z, requireLevel, ac, dam, gold);
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("                                              xxx 도씨검을 해제하였습니다 xxx");
                    Console.WriteLine("");
                    isEquipped[18] = false;
                    isEquipped[6] = false;
                    isEquipped[2] = false;
                    isEquipped[16] = false;
                    isEquipped[17] = false;

                    Inventory(order, eat, equipmentNames, isEquipped, quantities, eat2, gae, eat3, x, y, z, requireLevel, ac, dam, gold);
                }
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("                                                  그것은 인벤토리에 존재하지 않은 않는 아이템입니다.");
                Console.WriteLine("");
                Inventory2(order, eat, equipmentNames, isEquipped, quantities, eat2, gae, eat3, x, y, z, requireLevel, ac, dam, gold);
            }
        }


        static public void TerboNPC(string[] order, int eat, string[] equipmentNames, bool[] isEquipped, int?[] quantities, int eat2, string[] gae, int eat3, int?[] x, int?[] y, int?[] z, string[] requireLevel, string[] ac, string[] dam, int gold)
        {
            Console.WriteLine("");
            Console.WriteLine("                                            [털보] \" 어서오게나~ 무슨일로 나를 찾은겐가 ? \"");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("a. 아이템 구매");
            Console.WriteLine("b. 아이템 판매");
            Console.WriteLine("c. 천계의 장군에 대한 전설이 존재한다는데 알고 계신가요?");
            Console.WriteLine("d. 아... 그냥 인사차 들리러 왔습니다 하하;");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("  [back] 돌아 가기");
            Console.WriteLine("");

            string input = Console.ReadLine();

            if (input == "c")
            {
                Console.WriteLine("                                        [털보] \" 천계의 장군이시면.... 윤우주님을 말하는건가 ? \"");
                Console.WriteLine("                                               \" 머나먼 과거에 진성검, 백진도, 방천화극 이라고 불리는 \"");
                Console.WriteLine("                                               \" 전설로만 여겨지던 무기들을 만든 인물이라고는 들었다만... \"");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("  [back] 돌아 가기");
                Console.WriteLine("");

                string input1 = Console.ReadLine();
                {
                    if (input1 == "back")
                    {
                        TerboNPC(order, eat, equipmentNames, isEquipped, quantities, eat2, gae, eat3, x, y, z, requireLevel, ac, dam, gold);
                    }
                    else
                    {
                        Console.WriteLine("올바른 경로를 이용하십시오.");
                        Console.WriteLine("프로그램을 종료합니다");
                    }
                }

            }
            else if (input == "b")
            {
                Console.WriteLine("");
                Console.WriteLine("                                        [털보] \" 베타테스트에서는 사용할 수 없는 기능입니다. \"");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("  [back] 돌아 가기");
                Console.WriteLine("");
                string input2 = Console.ReadLine();
                {
                    if (input2 == "back")
                    {
                        TerboNPC(order, eat, equipmentNames, isEquipped, quantities, eat2, gae, eat3, x, y, z, requireLevel, ac, dam, gold);
                    }
                    else
                    {
                        Console.WriteLine("올바른 경로를 이용하십시오.");
                        Console.WriteLine("프로그램을 종료합니다");
                    }
                }
            }
            else if (input == "d")
            {
                Console.WriteLine("");
                Console.WriteLine("                                        [털보] \" ................싱겁 기는 \"");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("  [back] 돌아 가기");
                Console.WriteLine("");

                string input3 = Console.ReadLine();
                {
                    if (input3 == "back")
                    {
                        TerboNPC(order, eat, equipmentNames, isEquipped, quantities, eat2, gae, eat3, x, y, z, requireLevel, ac, dam, gold);
                    }
                    else
                    {
                        Console.WriteLine("올바른 경로를 이용하십시오.");
                        Console.WriteLine("프로그램을 종료합니다");
                    }
                }
                TerboNPC(order, eat, equipmentNames, isEquipped, quantities, eat2, gae, eat3, x, y, z, requireLevel, ac, dam, gold);
            }
            else if (input == "back")
            {
                GameScene(order, eat, equipmentNames, isEquipped, quantities, eat2, gae, eat3, x, y, z, requireLevel, ac, dam, gold);
            }
            else if (input == "a")
            {
                int?[] price = new int?[order.Length];
                price[16] = 1;
                price[17] = 400;
                price[18] = 250;

                string[] tradeEquipmentName = new string[order.Length];
                tradeEquipmentName[16] = "      목도    ";
                tradeEquipmentName[17] = "      장창  ";
                tradeEquipmentName[18] = "      도씨검";


                Console.WriteLine("");
                Console.WriteLine("보유 금전 : " + gold + " 전");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("판매목록");
                Console.WriteLine("");
                Console.WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
                Console.WriteLine("");
                for (int i = 16; i < 19; i++)
                {
                    Console.WriteLine($"{tradeEquipmentName[i]}                 {price[i]}전");
                }
                Console.WriteLine("");
                Console.WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
                Console.WriteLine("");
                Console.WriteLine("  구매를 원하는 아이템을 타이핑 하세요");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("  [back] 돌아 가기");
                Console.WriteLine("");

                string inputweapon = Console.ReadLine();
                if (inputweapon == "back")
                {
                    TerboNPC(order, eat, equipmentNames, isEquipped, quantities, eat2, gae, eat3, x, y, z, requireLevel, ac, dam, gold);
                }
                else if (inputweapon == "목도")
                {
                    if (order[16] == null)
                    {
                        if (gold < price[16])
                        {
                            Console.WriteLine("---------------------------------------------------------------------------------");
                            Console.WriteLine("");
                            Console.WriteLine("                                        [털보] \" 돈도 없는 주제에.......... \"");
                            Console.WriteLine("");
                            Console.WriteLine("---------------------------------------------------------------------------------");

                            TerboNPC(order, eat, equipmentNames, isEquipped, quantities, eat2, gae, eat3, x, y, z, requireLevel, ac, dam, gold);
                        }
                        else
                        {
                            Console.WriteLine("---------------------------------------------------------------------------------");
                            Console.WriteLine("");
                            Console.WriteLine("                                        [털보] \" 이용해 주셔서 감사합니다 ^^ \"");
                            Console.WriteLine("");
                            Console.WriteLine("---------------------------------------------------------------------------------");

                            int? v = gold - price[16];
                            gold = (int)v;

                            order[16] = "q. ";
                            equipmentNames[16] = "목도";
                            requireLevel[16] = "              ||       랩제 = ";
                            z[16] = 0;
                            dam[16] = "       ||   파괴력";
                            y[16] = 5;

                            TerboNPC(order, eat, equipmentNames, isEquipped, quantities, eat2, gae, eat3, x, y, z, requireLevel, ac, dam, gold);
                        }
                    }
                    else
                    {
                        Console.WriteLine("---------------------------------------------------------------------------------");
                        Console.WriteLine("");
                        Console.WriteLine("                                            [털보] \" 이미 구매하신 물품인데요..? \"");
                        Console.WriteLine("");
                        Console.WriteLine("---------------------------------------------------------------------------------");

                        TerboNPC(order, eat, equipmentNames, isEquipped, quantities, eat2, gae, eat3, x, y, z, requireLevel, ac, dam, gold);
                    }
                }

                else if (inputweapon == "장창")
                {
                    if (order[17] == null)
                    {
                        if (gold < price[17])
                        {
                            Console.WriteLine("---------------------------------------------------------------------------------");
                            Console.WriteLine("");
                            Console.WriteLine("                                        [털보] \" 돈도 없는 주제에.......... \"");
                            Console.WriteLine("");
                            Console.WriteLine("---------------------------------------------------------------------------------");

                            TerboNPC(order, eat, equipmentNames, isEquipped, quantities, eat2, gae, eat3, x, y, z, requireLevel, ac, dam, gold);
                        }
                        else
                        {
                            Console.WriteLine("---------------------------------------------------------------------------------");
                            Console.WriteLine("");
                            Console.WriteLine("                                        [털보] \" 이용해 주셔서 감사합니다 ^^ \"");
                            Console.WriteLine("");
                            Console.WriteLine("---------------------------------------------------------------------------------");

                            int? vv = gold - price[17];
                            gold = (int)vv;

                            order[17] = "r. ";
                            equipmentNames[17] = "장창";
                            requireLevel[17] = "              ||       랩제 = ";
                            z[17] = 0;
                            dam[17] = "       ||   파괴력";
                            y[17] = 30;

                            TerboNPC(order, eat, equipmentNames, isEquipped, quantities, eat2, gae, eat3, x, y, z, requireLevel, ac, dam, gold);
                        }
                    }
                    else
                    {
                        Console.WriteLine("---------------------------------------------------------------------------------");
                        Console.WriteLine("");
                        Console.WriteLine("                                            [털보] \" 이미 구매하신 물품인데요..? \"");
                        Console.WriteLine("");
                        Console.WriteLine("---------------------------------------------------------------------------------");

                        TerboNPC(order, eat, equipmentNames, isEquipped, quantities, eat2, gae, eat3, x, y, z, requireLevel, ac, dam, gold);
                    }
                }

                else if (inputweapon == "도씨검")
                {
                    if (order[18] == null)
                    {
                        if (gold < price[18])
                        {
                            Console.WriteLine("---------------------------------------------------------------------------------");
                            Console.WriteLine("");
                            Console.WriteLine("                                        [털보] \" 돈도 없는 주제에.......... \"");
                            Console.WriteLine("");
                            Console.WriteLine("---------------------------------------------------------------------------------");

                            TerboNPC(order, eat, equipmentNames, isEquipped, quantities, eat2, gae, eat3, x, y, z, requireLevel, ac, dam, gold);
                        }
                        else
                        {
                            Console.WriteLine("---------------------------------------------------------------------------------");
                            Console.WriteLine("");
                            Console.WriteLine("                                        [털보] \" 이용해 주셔서 감사합니다 ^^ \"");
                            Console.WriteLine("");
                            Console.WriteLine("---------------------------------------------------------------------------------");

                            int? vvv = gold - price[18];
                            gold = (int)vvv;

                            order[18] = "s. ";
                            equipmentNames[18] = "도씨검";
                            requireLevel[18] = "            ||       랩제 = ";
                            z[18] = 0;
                            dam[18] = "       ||   파괴력";
                            y[18] = 25;

                            TerboNPC(order, eat, equipmentNames, isEquipped, quantities, eat2, gae, eat3, x, y, z, requireLevel, ac, dam, gold);
                        }
                    }
                    else
                    {
                        Console.WriteLine("---------------------------------------------------------------------------------");
                        Console.WriteLine("");
                        Console.WriteLine("                                            [털보] \" 이미 구매하신 물품인데요..? \"");
                        Console.WriteLine("");
                        Console.WriteLine("---------------------------------------------------------------------------------");

                        TerboNPC(order, eat, equipmentNames, isEquipped, quantities, eat2, gae, eat3, x, y, z, requireLevel, ac, dam, gold);
                    }
                }

                else
                {
                    Console.WriteLine("---------------------------------------------------------------------------------");
                    Console.WriteLine("");
                    Console.WriteLine("잘못된 입력입니다. 처음부터 다시 시작해 주세요.");
                    Console.WriteLine("");
                    Console.WriteLine("---------------------------------------------------------------------------------");

                    TerboNPC(order, eat, equipmentNames, isEquipped, quantities, eat2, gae, eat3, x, y, z, requireLevel, ac, dam, gold);
                }
            }

            else
            {
                Console.Write("잘못된 입력입니다. 다시 입력해주세요");
                TerboNPC(order, eat, equipmentNames, isEquipped, quantities, eat2, gae, eat3, x, y, z, requireLevel, ac, dam, gold);
            }
        }


    }
}
