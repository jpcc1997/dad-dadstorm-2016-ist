﻿using System;
using CommonTypes;

namespace Slave
{
    public class ExecEnv
    {
        static void Main(string[] args)
        {
            // Reserved for testing - disabled in the multiple startup project 
            // PCS should be the responsible for the slaves creation
        }
    }

    public class Slave : MarshalByRefObject, ISlave, RemoteCmdInterface, ILogUpdate
    {
        private string url;
        private Import importObj;
        private Route routeObj;
        private Process processObj;
        private State state;
        private ILogUpdate pupetLogProxy;


        public string Url
        {
            get { return url; }
            set { url = value; }
        }

        public State State
        {
            get { return state; }
            set { state = value; }
        }
            
        public ILogUpdate PupetLogProxy
        {
            get { return pupetLogProxy; }
        }

        public Import ImportObj
        {
            get { return importObj; }
            set { importObj = value; }
        }

        public Process ProcessObj
        {
            get { return processObj; }
            set { processObj = value; }
        }

        public Route RouteObj
        {
            get { return routeObj; }
            set { routeObj = value; }
        }

        public Slave(Import importObj, Route routeObj, Process processObj, string url)
        {
            this.importObj = importObj;
            this.routeObj = routeObj;
            this.processObj = processObj;
            this.url = url;
            state = new UnfrozenState(this);
        }
        
        public void init()
        {
            // TO DO 
            // init server
            // init client to log pupetLogProxy
        }

        public void Dispatch(string input)
        {
            state.Dispatch(input);
        }

        public void Update(string toUpdate)
        {
            if (pupetLogProxy != null)
                state.Update(toUpdate);
        }

        public void Start()
        {
            init();
            Dispatch(null);
        }

        public void Interval(int ms)
        {
            throw new NotImplementedException();
        }

        public void Status()
        {
            throw new NotImplementedException();
        }

        public void Crash()
        {
            throw new NotImplementedException();
        }

        public void Freeze()
        {
            throw new NotImplementedException();
        }

        public void Unfreeze()
        {
            throw new NotImplementedException();
        }
    }
}
