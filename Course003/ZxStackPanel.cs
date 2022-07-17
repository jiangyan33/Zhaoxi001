using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Course003
{
    /// <summary>
    /// StackPanel默认排列控件,需求是增加一个Index依赖附加属性，让子控件的位置根据Index属性来控制
    ///  这里是依赖附加属性，类型有get和set方法，都是静态的，和依赖属性有区别
    /// </summary>
    public class ZxStackPanel : Panel
    {
        private readonly List<FrameworkElement> _frameworkElementList = new List<FrameworkElement>();

        /// <summary>
        /// 测量设置每一个子控件的高度信息
        /// </summary>
        /// <param name="availableSize">整个控件的可用大小</param>
        /// <returns></returns>
        protected override Size MeasureOverride(Size availableSize)
        {
            _frameworkElementList.Clear();

            var tempList = new List<KeyValuePair<int, FrameworkElement>>();

            var height = 0d;

            foreach (FrameworkElement item in this.InternalChildren)
            {
                item.Measure(availableSize);

                height += item.DesiredSize.Height;

                var index = GetIndex(item);

                if (index == 0)
                {
                    _frameworkElementList.Add(item);
                }
                else
                {
                    tempList.Add(new KeyValuePair<int, FrameworkElement>(index, item));
                }
            }

            tempList = tempList.OrderBy(item => item.Key).ToList();

            foreach (var item in tempList)
            {
                _frameworkElementList.Insert(item.Key, item.Value);
            }


            return new Size(availableSize.Width, height);
        }

        /// <summary>
        /// 将子控件排序，然后渲染到UI上
        /// </summary>
        /// <param name="finalSize"></param>
        /// <returns></returns>
        protected override Size ArrangeOverride(Size finalSize)
        {
            var height = 0d;

            foreach (FrameworkElement item in _frameworkElementList)
            {
                // 定位子元素，类似Canvas中的定位，设置Top和Left,然后给一个Size
                item.Arrange(new Rect(new Point(0, height), new Size(finalSize.Width, item.DesiredSize.Height)));

                height += item.DesiredSize.Height; 
            }

            return finalSize;
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static int GetIndex(DependencyObject obj)
        {
            return (int)obj.GetValue(IndexProperty);
        }

        public static void SetIndex(DependencyObject obj, int value)
        {
            obj.SetValue(IndexProperty, value);
        }

        public static readonly DependencyProperty IndexProperty =
            DependencyProperty.RegisterAttached("Index", typeof(int), typeof(ZxStackPanel), new PropertyMetadata(0));
    }
}
