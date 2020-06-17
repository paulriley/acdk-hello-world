using Amazon.CDK;
using Amazon.CDK.AWS.SNS;
using Amazon.CDK.AWS.SNS.Subscriptions;
using Amazon.CDK.AWS.SQS;

namespace AcdkHelloWorld
{
    public class AcdkHelloWorldStack : Stack
    {
        internal AcdkHelloWorldStack(Construct scope, string id, IStackProps props = null) : base(scope, id, props)
        {
            var queue = new Queue(this, "AcdkHelloWorldQueue", new QueueProps
            {
                VisibilityTimeout = Duration.Seconds(300)
            });

            var topic = new Topic(this, "AcdkHelloWorldTopic");

            topic.AddSubscription(new SqsSubscription(queue));
        }
    }
}
