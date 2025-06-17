namespace home
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World! 최민재");
            Console.WriteLine("Add:" + Add(10, 20));
            ValMain();
            CritcalAttackMain();
            StageMain();
            AttackWhile();
            MonsterListMain();
            PlayerAttackMain();
            
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
        //몬스터가 플레이를 공격한다. ->몬스터가 공격했을 때 (플레이어 피)가 깍인다.
        //몬스터는 공격력 < 플레이어는 체력 제공, 공격: 공격력으로 피를 깍는 행위.
        //변수: 바뀌는 것.(체력), (몬스터 공격력)
        //알고리즘: 몬스터의 공격력으로 플레이어의 체력을 깍는다. 체력 - 공격력
        //값을 설정하지않아서 작동하지않는다. 각 값의 공격력10, 체력 100으로 설정한다


        static void PlayerAttackMain()
        {
            int nMonsterAtk = 10;
            int nPlayerHP = 100;

            int nPlayerAtk = 15;
            int nMonsterHP = 100;
            Console.WriteLine("남은 hp"+ nPlayerHP);
            nPlayerHP = nPlayerHP - nMonsterAtk;
            Console.WriteLine("남은 hp"+ nPlayerHP);
        }

        //플레이어가 공격을 할 때 일정확률로 크리티컬이 터진다.
        static void CritcalAttackMain()
        {
            Console.WriteLine("CritcalAttackMain");
            int nPlayerAttack = 10;
            int nMonsterHP = 100;
            Random cRandom = new Random();
            int nRandom = cRandom.Next(1, 3); //랜덤으로 구한값.

            if (nRandom == 1)
            {
                nPlayerAttack = (int)(nPlayerAttack * 1.5);
                Console.WriteLine("크리티컬데미지!:" + nPlayerAttack);
            }
            else
                Console.WriteLine("데미지:" + nPlayerAttack);

            nMonsterHP = nMonsterHP - nPlayerAttack;

            Console.WriteLine("몬스터의 HP:"+ nMonsterHP);
            Console.WriteLine("랜덤값"+ nRandom);
        }

        
        
        static void StageMain()
        {
            Console.WriteLine("StageMain");
            Console.WriteLine("가고싶은곳을 입력하세요! (마을,  상점, 필드) ");
            string strStage = Console.ReadLine();

            switch (strStage)
            {
                case "마을":
                    Console.WriteLine("마을 입니다.");
                    break;
                case "상점":
                    Console.WriteLine("상점 입니다.");
                    break ;
                    case "필드":
                    Console.WriteLine("필드 입니다.");
                    break;
            }
        }

        
        static void AttackWhile()
        {
            Console.WriteLine("AttackWile");

            int nPlayerDemage = 10;
            int nMonsterHP = 100000;

            while (nMonsterHP > 0)
            {

                nMonsterHP = nMonsterHP - nPlayerDemage;//공격한다
                string msg = string.Format("몬스터가 데미지{0}를 HP가{1}되었다", nPlayerDemage, nMonsterHP);
                Console.WriteLine(msg);
            }
        }

        static void Battle()
        {
            //플레이어와 몬스터의 체력,공격력
            int nPlayerHP = 100;
            int nMonsterHP = 100;
            int nPlayerAtk = 15;
            int nMonsterAtk = 10;

            
            

        }
        


           
        



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




}
