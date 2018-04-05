//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace SuperAwesomeFancyPants.Inherit
//{
//    public enum EGameState
//    {
//        BeginRound, 
//        ThrowDice
//    }

//    public class GameModel
//    {

//    }

//    public abstract class GameBase
//    {
//        public EGameState ForState { get; set; }
//        public abstract void ProcessState(GameModel model);
//    }

//    public class BeginRoundState : GameBase
//    {
//        public BeginRoundState()
//        {
//            ForState = EGameState.BeginRound;
//        }

//        protected void WhatEver()
//        {

//        }

//        public override void ProcessState(GameModel model)
//        {
//            WhatEver();
//        }
//    }


//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            List<GameBase> listOfActions = new List<GameBase>();
//            listOfActions.Add(new BeginRoundState());

//            GameBase gameBase = listOfActions.First(x => x.ForState == EGameState.BeginRound);
//            gameBase.ProcessState();
//            Console.ReadKey();
//        }
//    }
//}
