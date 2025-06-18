namespace home
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello, World! 최민재");
            // Console.WriteLine("Add:" + Add(10, 20));
            // ValMain();
            //CritcalAttackMain();
            // StageMain();
            //AttackWhile();
            //MonsterListMain();
            //PlayerAttackMain();
            //MonsterSelectMain();
            PlayerBattleMain();
        }




        static int Add(int a, int b)
        {
            int c = a + b;
            return c;
        }

        static void ValMain()
        {
            int nScore = 0;
            float fRat = 1.0f / 4.0f;
            Console.WriteLine("Score:" + nScore);
            Console.WriteLine("Rat:" + fRat);
        }
        //몬스터가 플레이어를 공격한다. ->몬스터가 공격했을 때 (플레이어 피)가 깍인다.
        //몬스터는 공격력 < 플레이어는 체력 제공, 공격: 공격력으로 피를 깍는 행위.
        //데이터: 바뀌는 것.(체력), (몬스터 공격력)
        //알고리즘: 몬스터의 공격력으로 플레이어의 체력을 깍는다. 체력 - 공격력
        //값을 설정하지않아서 작동하지않는다. 각 값의 공격력10, 체력 100으로 설정한다


        static void PlayerAttackMain()
        {
            int nMonsterAtk = 10;
            int nPlayerHP = 100;
            Console.WriteLine("몬스터의 공격력:" + nMonsterAtk + "남은 hp:" + nPlayerHP);
            nPlayerHP = nPlayerHP - nMonsterAtk;
            Console.WriteLine("몬스터의 공격력:" + nMonsterAtk + "남은 hp:" + nPlayerHP);

        }

        //플레이어가 (몬스터를)공격을 할 때 일정확률로 크리티컬이 터진다.
        //플레이어가 공격 -> 플레이어의 공격력, 몬스터의 체력이 필요하다.
        //데이터 : 플레이어의 공격력, 몬스터의 체력
        //알고리즘: 플레이어가 몬스터를 공격하는데, 일정확률로 크리티컬이 발생한다.
        //일정확률? -> 플레이어가 몬스터를 공격한다. -> 때릴 때 일정확률로 크리티컬이 발생하고 데미지가 1.5배가 된다.

        static void CritcalAttackMain()
        {
            Console.WriteLine("CritcalAttackMain");
            int nPlayerAtk = 10;
            int nMonsterHP = 100;
            //일정확률로 공격하기 전에 데미지를 1.5배 증가시킨다.
            Random cRandom = new Random();
            int nRandom = cRandom.Next(1, 3); //1~2의 값이 나온다 1/2
            //int nRandom = cRandom.next(0, 3); //0,1,2의 값이 나온다 1/3
            Console.WriteLine("몬스터의 공격력:" + nPlayerAtk + "남은 hp" + nMonsterHP);
            if (nRandom == 1)
            {
                Console.WriteLine("Critical Attack!");
                nMonsterHP = nMonsterHP - (int)(nPlayerAtk * 1.5);//몬스터를 때린다
            }
            else
                nMonsterHP = nMonsterHP - nPlayerAtk;//몬스터를 때린다

            Console.WriteLine("몬스터의 공격력:" + nPlayerAtk + "남은 hp" + nMonsterHP);
            Console.WriteLine("Random:" + nRandom);


        }

        //플레이어가 공격하면 몬스터는 반격하고, 둘중하나가 죽을 때 까지 전투가 끝나지않고, 한쪽이 죽으면 끝남
        //데이터: 플레이어의 공격력, 플레이어의 체력, 몬스터의 공격력, 몬스터의 체력
        //알고리즘: 플레이어가 먼저 공격하고, 몬스터가 맞고나서 반격 한다. 한쪽이 죽을때까지.

        static void PlayerBattleMain()
        {
            int nPlayerAtk = 10;
            int nMonsterHP = 100;
            int nMonsterAtk = 10;
            int nPlayerHP = 100;
            Console.WriteLine("몬스터의 공격력"+ nMonsterAtk +"남은 hp"+nPlayerHP);
            Console.WriteLine("플레이어의 공격력" +nPlayerAtk + "남은 hp" + nMonsterHP);
            Random cRandom = new Random();
            
          


                while (nPlayerHP >0 == nMonsterHP > 0) //둘 다 0보다 체력이 있어야 전투가 진행이 됨

            {
                int Random = cRandom.Next(1, 3);
                if (Random == 1)
                {
                    int nCriticalAttack = (int)(nPlayerAtk * 1.5);
                    nMonsterHP = nMonsterHP - nCriticalAttack;

                    {
                        Console.WriteLine("플레이어의 크리티컬 데미지");
                    }
                    
                }
                else//크리티컬 데미지가 들어가면 일반공격은 안 들어가게 해줌
                    nMonsterHP = nMonsterHP - nPlayerAtk;
                Console.WriteLine("공격전, 플레이어의 공격력" + nPlayerAtk + "남은 몬스터hp" + nMonsterHP);
                if (nMonsterHP <=0) 
                {
                    Console.WriteLine("몬스터 사망");
                    break;
                }

                {
                        int nRandom = cRandom.Next(1, 3);
                    if (nRandom == 1)
                    {



                        int nCriticalAttack = (int)(nMonsterAtk * 1.5);
                        nPlayerHP = nPlayerHP - nCriticalAttack;
                        {
                            Console.WriteLine("몬스터의 크리티컬 데미지");
                        }
                    }
                    else//크리티컬 데미지가 들어가면 일반공격은 안 들어가게 해줌
                    nPlayerHP = nPlayerHP - nMonsterAtk;

                    Console.WriteLine("공격전, 몬스터의 공격력" + nMonsterAtk + "남은 플레이어hp" + nPlayerHP);
                    if (nPlayerHP <= 0) 
                    {
                        Console.WriteLine("플레이어 사망");
                        break;
                    }
                    Console.WriteLine("다음 턴");
                }
            }
                Console.WriteLine("전투종료");
        }

        //마을,필드,상점 중에서 이동장소를 입력하면 그 장소의 이름이 나오는 프로그램작성.
        //데이터: 마을,필드,상점, 입력값
        //알고리즘 : 입력값 안내를 표시하는 메세지를 먼저 출력하고, 입력값이 마을이면 마을입니다. 상점... 사냥터...

        static void StageMain()
        {
            string strTown = "마을";
            string strField = "사냥터";
            string strStore = "상점";
            Console.WriteLine("이동 할 장소를 입력하세요.(마을, 사냥터, 상점)");
            string strInput = Console.ReadLine();

            switch (strInput)
            {
                case "마을":
                    Console.WriteLine("마을 입니다");
                    break;
                case "사냥터":
                    Console.WriteLine("사낭터 입니다");
                    break;
                case "상점":
                    Console.WriteLine("상점 입니다");
                    break;
                default:
                    Console.WriteLine("장소를 잘못입력했습니다");
                    break;
            }
            /*
            if(strInput == strTown)
            {
                Console.WriteLine("마을 입니다.");
            }
            else if(strInput == strField)
            {
                Console.WriteLine("사냥터 입니다");
            }
            else if (strInput == strStore)
            {
                Console.WriteLine("상점 입니다");
            }
            else
            {
                Console.WriteLine("장소를 잘못 입력했습니다");
            }
            Console.WriteLine("StageMain");
            */

        }

        //몬스터가 플레이어를 (죽을 때 까지: 플레이어의 hp가 0이 될 때)공격한다.
        //크리티컬 데미지는 몬스터가 플레이어를 공격하기 전에 데미지가 상승해야한다
        static void AttackWhile()
        {
            Console.WriteLine("AttackWhile");
            int nMonsterAtk = 10;
            int nPlayerHP = 100;
            //살아있을 때 공격을 한다.//코드가 쉽다 ->코드가 짧다.//햇갈리지않는다 -> 이 조건 그대로 생각한다
            while (true)
            {
                Console.WriteLine("공격전,몬스터의 공격력:" + nMonsterAtk + "남은 hp" + nPlayerHP);
                if (nPlayerHP <= 0) break;
                nPlayerHP = nPlayerHP - nMonsterAtk;
                Console.WriteLine("공격후, 몬스터의 공격력:" + nMonsterAtk + "남은 hp" + nPlayerHP);
            }


        }

        static void CriticalAttackWhile()
        {
            Console.WriteLine("AttackCritcalWhile");
            int nMonsterAtk = 10;
            int nPlayerHP = 100;

            Random cRandom = new Random();//랜덤을 생성한다.//랜덤기를 만든다


            while (nPlayerHP > 0)
            {
                Console.WriteLine("공격전,몬스터의 공격력:" + nMonsterAtk + "남은 hp" + nPlayerHP);
                //Random cRandom = new Random();//랜덤을 하기전에 생성한다.
                int nRandom = cRandom.Next(1, 3);//랜덤값을 생성한다. //랜덤기를 이용해서 숫자를 생성한다
                if (nRandom == 1)
                {
                    int nCriticalAttack = (int)(nMonsterAtk * 1.5);//크리티컬 데미지를 미리저장해서 알기쉽게 계산해둔다.
                    nPlayerHP = nPlayerHP - nCriticalAttack;//공격을 할 때 1회성으로 계산된 데미지를 사용한다
                    Console.WriteLine("크리티컬 데미지:" + nCriticalAttack);

                }
                else
                    nPlayerHP = nPlayerHP - nMonsterAtk;
                Console.WriteLine("공격후, 몬스터의 공격력:" + nMonsterAtk + "남은 hp" + nPlayerHP);
                //랜덤을 끝나면 상제한다. //랜덤기를 반복문이 종료될 때 버린다
            }
            //생성된 랜덤기를 삭제한다.//랜덤기를 함수가 종료될 때 버린다.






            static void MonsterListMain()
            {
                Console.WriteLine("MonsterListMain");

                List<string> listMonster = new List<string>();

                listMonster.Add("슬라임");
                listMonster.Add("스켈레톤");
                listMonster.Add("좀비");
                listMonster.Add("드래곤");
                //첫번째값은 [0]으로 접근하고, 마지막값은 몬스터수-1이 마지막 값이다.
                Console.WriteLine(listMonster[0]);
                Console.WriteLine(listMonster[3]);
                //Console.WriteLine(listMonster[4]; // 잘못된 접근을 하면 프로그램이 녹는다

                //for문을 이용해 반복해서 출력한다
                for (int i = 0; i < listMonster.Count; i++)
                    Console.WriteLine(string.Format("monster[{0}]:{1}", i, listMonster[i]));
            }









        }
        static void MonsterSelectMain()
        {
            Console.WriteLine("이동 할 장소를 입력하세요.(평원,무덤,던전,계곡)");

            string strInput = Console.ReadLine();

            int nMonsterAttack = 10;
            int nMonsterHP = 100;

            switch (strInput)
            {
                case "평원":
                    Console.WriteLine("슬라임이 출연합니다.");
                    nMonsterAttack = 5;
                    nMonsterHP = 20;
                    break;
                case "무덤":
                    Console.WriteLine("스켈레톤 출연합니다.");
                    nMonsterAttack = 10;
                    nMonsterHP = 30;
                    break;
                case "던전":
                    Console.WriteLine("좀비 출연 합니다.");
                    nMonsterAttack = 20;
                    nMonsterHP = 50;
                    break;
                case "계곡":
                    Console.WriteLine("드래곤이 출연 합니다.");
                    nMonsterAttack = 50;
                    nMonsterHP = 200;
                    break;
                default:
                    Console.WriteLine("장소를 잘못입력했습니다.");
                    break;



            }

            //여기에 전투코드를 삽입하면 작동한다.
        }
    }
}