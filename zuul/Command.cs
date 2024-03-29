namespace Zuul
{
	public class Command
	{
		private string commandWord;
		private string secondWord;
        private string thirdWord;

        /**
		 * Create a command object. First and second word must be supplied, but
		 * either one (or both) can be null. The command word should be null to
		 * indicate that this was a command that is not recognised by this game.
		 */
        public Command(string first, string second,string third)
		{
			commandWord = first;
			secondWord = second;
            thirdWord = third;
        }

		/**
		 * Return the command word (the first word) of this command. If the
		 * command was not understood, the result is null.
		 */
		public string GetCommandWord()
		{
			return commandWord;
		}

		/**
		 * Return the second word of this command. Returns null if there was no
		 * second word.
		 */
		public string GetSecondWord()
		{
			return secondWord;
		}

        public string GetThirdWord()
        {
            return thirdWord;
        }

        /**
		 * Return true if this command was not understood.
		 */
        public bool IsUnknown()
		{
			return (commandWord == null);
		}

		/**
		 * Return true if the command has a second word.
		 */
		public bool HasSecondWord()
		{
			return (secondWord != null);
		}

		public bool HasThirdWord() 
		{
			return (thirdWord != null);
		}
	}
}
