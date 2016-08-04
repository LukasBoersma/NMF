﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq.Expressions;

namespace NMF.Expressions.Test
{
    [TestClass]
    public class ExceptionTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ObservableFuncT1_ExplicitFromNull_ArgumentNullException()
        {
            Expression<Func<object, string>> expression = null;
            ObservingFunc<object, string> func = new ObservingFunc<object, string>(expression);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ObservableFuncT2_ExplicitFromNull_ArgumentNullException()
        {
            Expression<Func<object, object, string>> expression = null;
            ObservingFunc<object, object, string> func = new ObservingFunc<object, object, string>(expression);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ObservableFuncT3_ExplicitFromNull_ArgumentNullException()
        {
            Expression<Func<object, object, object, string>> expression = null;
            ObservingFunc<object, object, object, string> func = new ObservingFunc<object, object, object, string>(expression);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ObservableFuncT4_ExplicitFromNull_ArgumentNullException()
        {
            Expression<Func<object, object, object, object, string>> expression = null;
            ObservingFunc<object, object, object, object, string> func = new ObservingFunc<object, object, object, object, string>(expression);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ObservableFuncT5_ExplicitFromNull_ArgumentNullException()
        {
            Expression<Func<object, object, object, object, object, string>> expression = null;
            ObservingFunc<object, object, object, object, object, string> func = new ObservingFunc<object, object, object, object, object, string>(expression);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ObservableFuncT6_ExplicitFromNull_ArgumentNullException()
        {
            Expression<Func<object, object, object, object, object, object, string>> expression = null;
            ObservingFunc<object, object, object, object, object, object, string> func = new ObservingFunc<object, object, object, object, object, object, string>(expression);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ObservableFuncT7_ExplicitFromNull_ArgumentNullException()
        {
            Expression<Func<object, object, object, object, object, object, object, string>> expression = null;
            ObservingFunc<object, object, object, object, object, object, object, string> func = new ObservingFunc<object, object, object, object, object, object, object, string>(expression);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ObservableFuncT8_ExplicitFromNull_ArgumentNullException()
        {
            Expression<Func<object, object, object, object, object, object, object, object, string>> expression = null;
            ObservingFunc<object, object, object, object, object, object, object, object, string> func = new ObservingFunc<object, object, object, object, object, object, object, object, string>(expression);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ObservableFuncT9_ExplicitFromNull_ArgumentNullException()
        {
            Expression<Func<object, object, object, object, object, object, object, object, object, string>> expression = null;
            ObservingFunc<object, object, object, object, object, object, object, object, object, string> func = new ObservingFunc<object, object, object, object, object, object, object, object, object, string>(expression);
        }

        [TestMethod]
        public void ObservableFuncT1_ImplicitOperatorFromNull_ArgumentNullException()
        {
            Expression<Func<object, string>> expression = null;
            ObservingFunc<object, string> func = expression;
            Assert.IsNull(func);
        }

        [TestMethod]
        public void ObservableFuncT2_ImplicitOperatorFromNull_ArgumentNullException()
        {
            Expression<Func<object, object, string>> expression = null;
            ObservingFunc<object, object, string> func = expression;
            Assert.IsNull(func);
        }

        [TestMethod]
        public void ObservableFuncT3_ImplicitOperatorFromNull_ArgumentNullException()
        {
            Expression<Func<object, object, object, string>> expression = null;
            ObservingFunc<object, object, object, string> func = expression;
            Assert.IsNull(func);
        }

        [TestMethod]
        public void ObservableFuncT4_ImplicitOperatorFromNull_ArgumentNullException()
        {
            Expression<Func<object, object, object, object, string>> expression = null;
            ObservingFunc<object, object, object, object, string> func = expression;
            Assert.IsNull(func);
        }

        [TestMethod]
        public void ObservableFuncT5_ImplicitOperatorFromNull_ArgumentNullException()
        {
            Expression<Func<object, object, object, object, object, string>> expression = null;
            ObservingFunc<object, object, object, object, object, string> func = expression;
            Assert.IsNull(func);
        }

        [TestMethod]
        public void ObservableFuncT6_ImplicitOperatorFromNull_ArgumentNullException()
        {
            Expression<Func<object, object, object, object, object, object, string>> expression = null;
            ObservingFunc<object, object, object, object, object, object, string> func = expression;
            Assert.IsNull(func);
        }

        [TestMethod]
        public void ObservableFuncT7_ImplicitOperatorFromNull_ArgumentNullException()
        {
            Expression<Func<object, object, object, object, object, object, object, string>> expression = null;
            ObservingFunc<object, object, object, object, object, object, object, string> func = expression;
            Assert.IsNull(func);
        }

        [TestMethod]
        public void ObservableFuncT8_ImplicitOperatorFromNull_ArgumentNullException()
        {
            Expression<Func<object, object, object, object, object, object, object, object, string>> expression = null;
            ObservingFunc<object, object, object, object, object, object, object, object, string> func = expression;
            Assert.IsNull(func);
        }

        [TestMethod]
        public void ObservableFuncT9_ImplicitOperatorFromNull_ArgumentNullException()
        {
            Expression<Func<object, object, object, object, object, object, object, object, object, string>> expression = null;
            ObservingFunc<object, object, object, object, object, object, object, object, object, string> func = expression;
            Assert.IsNull(func);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ObservableFuncT1_NullExpression_ArgumentNullException()
        {
            var test = Observable.Func<object, string>(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ObservableFuncT2_NullExpression_ArgumentNullException()
        {
            var test = Observable.Func<object, object, string>(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ObservableFuncT3_NullExpression_ArgumentNullException()
        {
            var test = Observable.Func<object, object, object, string>(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ObservableFuncT4_NullExpression_ArgumentNullException()
        {
            var test = Observable.Func<object, object, object, object, string>(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ObservableFuncT5_NullExpression_ArgumentNullException()
        {
            var test = Observable.Func<object, object, object, object, object, string>(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ObservableFuncT6_NullExpression_ArgumentNullException()
        {
            var test = Observable.Func<object, object, object, object, object, object, string>(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ObservableFuncT7_NullExpression_ArgumentNullException()
        {
            var test = Observable.Func<object, object, object, object, object, object, object, string>(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ObservableFuncT8_NullExpression_ArgumentNullException()
        {
            var test = Observable.Func<object, object, object, object, object, object, object, object, string>(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ObservableFuncT9_NullExpression_ArgumentNullException()
        {
            var test = Observable.Func<object, object, object, object, object, object, object, object, object, string>(null);
        }
    }
}
