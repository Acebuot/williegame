using System;

namespace WilligeGame
{
    /// <summary>
    /// Class to represent a hand in the game
    /// </summary>
    public partial class WillieHand
    {
        private int _CardOne;
        private int _CardTwo;
        private int _Willie;
        public const string cardcvalueTooLow = "Card Value too low";
        public const string cardcvalueTooHigh = "Card Value too High";


        /// <summary>
        /// Pass the values of the two cards as you construct the hand
        /// </summary>
        /// <param name="CardOne">Numeric value of the first card</param>
        /// <param name="CardTwo">Numeric value of the second card</param>
        public WillieHand(int CardOne, int? CardTwo)
        {
            _CardOne = CardOne;
            _CardTwo = CardTwo.GetValueOrDefault();

            if (CardOne >= 14 || CardTwo >= 14)
                throw new System.ArgumentOutOfRangeException(cardcvalueTooHigh);
            else if (CardOne < 1 || CardTwo < 0)
                throw new System.ArgumentOutOfRangeException(cardcvalueTooLow);

        }

        /// <summary>
        /// Pass the values of the one card as you construct the hand
        /// </summary>
        /// <param name="CardOne">Numeric value of the first card</param>
        public WillieHand(int CardOne)
        {
            _CardOne = CardOne;
            _CardTwo = 0;
        }

        /// <summary>
        /// Willie value of the hand
        /// </summary>
        public int Willie
        {
            get
            {
                if (_CardOne > 10)
                    _Willie = 10;
                else
                    _Willie = _CardOne;
                if (_CardTwo > 10)
                    _Willie += 10;
                else
                    _Willie += _CardTwo;
                return _Willie;
            }
        }
        public int CardOne
        {
            get
            {
                return _CardOne;
            }
        }
        public int CardTwo
        {
            get
            {
                return _CardTwo;
            }
        }
    }
}
