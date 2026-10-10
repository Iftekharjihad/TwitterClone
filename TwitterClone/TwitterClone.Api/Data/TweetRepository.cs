using TwitterClone.Domain.Entities;

namespace TwitterClone.Api.Data
{
    public class TweetRepository
    {
        private readonly List<Tweet> _tweets = new List<Tweet>();
        public List<Tweet> GetTweets()
        {
            return _tweets;
        }
        public List<Tweet> GetTweetByUserId(Guid userId)
        {
            return _tweets.Where(t => t.UserId == userId).ToList();
        }
        public Tweet? GetTweetById(Guid Id)
        {
            return _tweets.SingleOrDefault(t => t.Id == Id);
        }
        public Tweet AddTweet(Tweet tweet)
        {
            _tweets.Add(tweet);
            return tweet;
        }
        public Tweet UpdateTweet(Tweet tweet)
        {
            _tweets.RemoveAll(t => t.Id == tweet.Id);
            _tweets.Add(tweet);
            return tweet;
        }
        public bool DeleteTweet(Tweet tweet)
        {
            return _tweets.Remove(tweet);
        }
    }
}
