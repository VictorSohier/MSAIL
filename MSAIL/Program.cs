﻿using System.Threading.Tasks;

/*
 * Authored by: T3CHN01200
 * Discord: T3CHN01200#7178
 * Last updated: 2019/7/7
 */

namespace MSAIL
{

    /// <summary>
    /// Container for the program
    /// </summary>
    class Program
    {

        static void Main(string[] args)
        {

            new Program().MainAsync().GetAwaiter().GetResult();

        }

        /// <summary>
        /// Just kickstarts the bot
        /// </summary>
        public async Task MainAsync()
        {

            Bot bot = new Bot();

            await Task.Delay(-1);

        }

    }

}
