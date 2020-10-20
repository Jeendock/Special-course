using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Player eunsoo = new Player();
            eunsoo.Move();

            Enemy enemy = new Enemy();
            enemy.Move();  
        }
    }

    public class Unit
    {
        public virtual void Move()
        {
            Console.WriteLine("움직이기");
        }
        public virtual void Jump()
        {
            Console.WriteLine("점프");
        }
        public virtual void Attack()
        {
            Console.WriteLine("공격");
        }
        public virtual void Dead()
        {
            Console.WriteLine("죽었다");
        }
    }


    public class Player : Unit 
    {
        private string Name;

        public Player()
        {
            Name = "임은수";
            Console.WriteLine(Name);
            Console.WriteLine("생성자 호출");
        }
        public override void Move()
        {
            base.Move();
        }
        public override void Jump()
        {
            base.Jump();      
        }
        public override void Attack()
        {
            base.Attack();
        }
        public void AFK()
        {
            Console.WriteLine("장시간 미입력으로 인한 수면...");
            //zZz
        }
        public void Hit()
        {
            Console.WriteLine("적에게 맞았다");
        }
        public void Getitem()
        {
            Console.WriteLine("무언가를 얻었다");
        }
        public void Communication()
        {
            Console.WriteLine("오박사가 말을 걸어 왔다");
        }
        public override void Dead()
        {
            base.Dead();
        }
    }

    public class Enemy : Unit
    {
        public string Type;

        public Enemy()
        {
            Type = "불속성 효자";
            Console.WriteLine("적 생성자 호출");
        }
        public override void Move()
        {
            base.Move();
        }
        public override void Jump()
        {
            base.Jump();
        }
        public override void Attack()
        {
            base.Attack();
        }
        public void Hit()
        {
            Console.WriteLine("맞고만 사는 인생");
            //?
        }
        public override void Dead()
        {
            base.Dead();
        }
        public void Dropitem()
        {
            Console.WriteLine("아 레전더리 내놔!!!");
            //레어 같은 거 말고!!
        }
    }
}