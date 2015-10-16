using Broccoli;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curly
{
    /// <summary>
    /// Phasellus dictum tortor sed mi porttitor, in iaculis libero facilisis. Donec gravida mauris eu sapien viverra egestas. Ut fringilla nisl sit amet sagittis aliquam. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. 
    /// </summary>
    class UserFactory
    {
        /// <summary>
        /// Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Proin porta nibh vel nisi dapibus, nec hendrerit sapien pharetra. Pellentesque dignissim facilisis libero quis fringilla. Morbi in suscipit augue.
        /// </summary>
        public AnalyseUser Analyser { get; } = new AnalyseUser();
        /// <summary>
        ///  Pellentesque ex tellus, tincidunt nec tortor sed, vulputate congue eros. Maecenas vitae erat orci. 
        /// </summary>
        public Logger Logger { get; } = new Logger();
        /// <summary>
        /// Vivamus in ligula ac sapien dictum accumsan nec vel elit. Donec semper est id commodo tempus. Donec in mollis ante. Suspendisse volutpat nulla nisl, venenatis facilisis augue faucibus ac. In eget velit non felis pellentesque condimentum quis sit amet sem. Etiam maximus erat dolor, ac pretium massa placerat a. Donec non gravida neque, non molestie turpis. Phasellus in eros eget risus malesuada hendrerit. Vestibulum dignissim sem nunc, non tempus lorem fermentum a. Curabitur eget velit id odio faucibus pellentesque ac quis mi. Duis suscipit suscipit porta. Cras pellentesque finibus lacinia. Mauris sagittis convallis purus vitae interdum. Pellentesque dolor purus, hendrerit eu odio ac, fermentum rhoncus quam.
        /// </summary>
        /// <param name="count">Integer eu est fermentum, rutrum leo in, gravida velit. </param>
        /// <returns>Proin et pretium urna. Integer consequat ipsum et eros convallis vestibulum. </returns>
        public List<User> BuildUsers(int count)
        {
            List<User> userList = Enumerable.Range(0, count).Select(i => new User
            {
                _id = $"{i}",
                name = "Bob",
            }).ToList();
            Logger.LogAll(userList.Select(u => new Log { Message = $"{u.name} Created" }));

            foreach (var usr in userList)
            {
                try
                {
                    Analyser.Function1(usr);
                }
                catch(Exception ex)
                {
                    Logger.Log(new Log { Message = ex.Message });
                }
            }
            return userList;
        }

    }
}
