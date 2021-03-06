﻿using CF.VRent.Common;
using CF.VRent.Email.EmailSender.Entity;
using CF.VRent.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CF.VRent.Email.EmailSender.Payment
{
    public class IndirectFeeDeductionSuccessSender : IIndirectFeeDeductionSuccessSender
    {
        public IEmailSenderValidation Validation
        {
            get;
            set;
        }

        public EmailType[] EmailTypes
        {
            get { return new EmailType[] {
                EmailType.Preauthorization_IndirectFeeDeduction_Successful
            }; }
        }

        public IndirectFeeDeductionSuccessSender()
        {
            if (this.Validation == null)
            {
                Validation = new EmailSenderValidation();
            }
        }

        public void Send(EmailParameterEntity parameters, params string[] to)
        {
            if (this.Validation.Validate(onSendEvent))
            {
                foreach (EmailType type in this.EmailTypes)
                {
                    LogInfor.EmailLogWriter.WriteInfo(this.GetType().Name + ":" + type.ToStr() + " in", to.ObjectToJson(), "Email");
                    var callBack = onSendEvent.BeginInvoke(parameters, type, to, null, null);
                    onSendEvent.EndInvoke(callBack);
                    LogInfor.EmailLogWriter.WriteInfo(this.GetType().Name + ":" + type.ToStr() + " out", to.ObjectToJson(), "Email");
                }
            }
        }

        public event Action<EmailParameterEntity, EmailType, string[]> onSendEvent;


        public EmailParameterEntity Parameters
        {
            get;
            private set;
        }
    }
}
