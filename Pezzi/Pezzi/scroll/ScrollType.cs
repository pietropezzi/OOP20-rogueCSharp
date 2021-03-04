using System;
using System.Collections.Generic;
using System.Text;

namespace Pezzi.scroll
{
    /// <summary>
    /// Class that represents a <see cref="IScroll"/> type.
    /// </summary>
    public class ScrollType
    {
        // SCROLLS
        public static readonly ScrollType SCROLL_I = new ScrollType(ScrollEffect.GAIN, 15, new KeyValuePair<int, int>(1, 3));
        public static readonly ScrollType SCROLL_II = new ScrollType(ScrollEffect.GAIN, 25, new KeyValuePair<int, int>(1, 3));
        public static readonly ScrollType SCROLL_III = new ScrollType(ScrollEffect.GAIN, 15, new KeyValuePair<int, int>(3, 5));
        public static readonly ScrollType SCROLL_IV = new ScrollType(ScrollEffect.GAIN, 25, new KeyValuePair<int, int>(3, 5));
        public static readonly ScrollType SCROLL_V = new ScrollType(ScrollEffect.GAIN, 15, new KeyValuePair<int, int>(5, 7));
        public static readonly ScrollType CORRUPT_SCROLL_I = new ScrollType(ScrollEffect.LOSE, 30, new KeyValuePair<int, int>(1, 3));
        public static readonly ScrollType CORRUPT_SCROLL_II = new ScrollType(ScrollEffect.LOSE, 20, new KeyValuePair<int, int>(3, 5));

        public static IEnumerable<ScrollType> Values
        {
            get
            {
                yield return SCROLL_I;
                yield return SCROLL_II;
                yield return SCROLL_III;
                yield return SCROLL_IV;
                yield return SCROLL_V;
                yield return CORRUPT_SCROLL_I;
                yield return CORRUPT_SCROLL_II;
            }
        }

        private ScrollEffect effect;
        private int duration;
        private KeyValuePair<int, int> scrollValue;

        ScrollType(ScrollEffect effect,int duration, KeyValuePair<int, int> value) =>
            (this.effect, this.duration, this.scrollValue) = (effect, duration, value);

        /// <summary>
        /// Gets the scroll's effect.
        /// </summary>
        /// <returns>the scroll's effect.</returns>
        public ScrollEffect GetEffect() => this.effect;

        /// <summary>
        /// Generates the scroll value of the scroll.
        /// </summary>
        /// <returns>the scroll value.</returns>
        public int GenerateScrollValue()
        {
            int ret = new Random().Next(scrollValue.Key, scrollValue.Value + 1);
            if (this.effect.Equals(ScrollEffect.LOSE))
            {
                return ret * -1;
            } else
            {
                return ret;
            }
        }

        /// <summary>
        /// Gets the scroll's effect duration.
        /// </summary>
        /// <returns>the scroll's effect duration.</returns>
        public int GetEffectDuration() => this.duration;
    }
}
