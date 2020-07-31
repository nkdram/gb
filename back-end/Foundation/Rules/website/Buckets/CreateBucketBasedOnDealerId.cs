// Sitecore.Buckets.Rules.Bucketing.Actions.CreateItemNameBasedPath<T>
using Sitecore.Buckets.Rules.Bucketing;
using Sitecore.Buckets.Util;
using Sitecore.Diagnostics;
using Sitecore.Rules.Actions;


namespace Globags.Foundation.Rules.Buckets
{
    /// <summary>
    /// Defines the run class.
    /// </summary>
    /// <typeparam name="T">The rule context.</typeparam>
    public class CreateBucketBasedOnProductId<T> : RuleAction<T> where T : BucketingRuleContext
    {
        /// <summary>
        /// Gets or sets the number of levels
        /// </summary>
        /// <value>The script id.</value>
        public string Levels
        {
            get;
            set;
        }

        /// <summary>
        /// Executes the specified rule context.
        /// </summary>
        /// <param name="ruleContext">The rule context.</param>
        public override void Apply(T ruleContext)
        {
            Assert.ArgumentNotNull(ruleContext, "ruleContext");

            if (!ruleContext.BucketItem.Fields[Templates.ProductPage.ProductID]?.HasValue ?? true)
                return;

            //Get ProductID
            var productId = ruleContext.BucketItem.Fields[Templates.ProductPage.ProductID].Value;
            if (int.TryParse(Levels, out int result))
            {
                if (result > productId.Length)
                {
                    result = productId.Length;
                }
                char[] values = productId.Substring(0, result).ToCharArray();
                ruleContext.ResolvedPath = string.Join(Constants.ContentPathSeperator, values).ToLowerInvariant();
            }
            else
            {
                Log.Warn("CreateBucketBasedOnProductId: Cannot resolve item path by this rule", this);
            }
        }
    }
}
