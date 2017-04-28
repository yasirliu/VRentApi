﻿using CF.VRent.Email.EmailSender.Entity;
using CF.VRent.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CF.VRent.Common;

namespace CF.VRent.Email.EmailSender.Payment
{
    public class PreauthSuccessSender : IPreauthSuccessSender
    {
        public IEmailSenderValidation Validation
        {
            get;
            set;
        }

        public PreauthSuccessSender()
        {
            if (Validation == null)
            {
                Validation = new EmailSenderValidation();
            }
        }

        public virtual void Send(EmailParameterEntity parameters,params string[] to)
        {
            if (Validation.Validate(onSendEvent))
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


        public EmailType[] EmailTypes
        {
            get
            {
                return new EmailType[] { 
                    EmailType.Preauthorization_Preauth_Successful};
            }
        }

        public EmailParameterEntity Parameters
        {
            get;
            private set;
        }
    }
}
