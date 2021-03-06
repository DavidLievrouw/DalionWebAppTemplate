import * as React from "react";
import { IApplicationInfo } from '../facades/applicationInfo';
import { CompanyLogo } from './CompanyLogo';

export interface ILandingProps {
  applicationInfo: IApplicationInfo;
}

export interface ILandingState { }

export class Landing extends React.Component<ILandingProps, ILandingState> {
  constructor(props: ILandingProps) {
    super(props);
  }

  render() {
    return (
      <div className="ui middle aligned center aligned full-height padded padded-content grid">
        <div className="column">
          <CompanyLogo applicationInfo={this.props.applicationInfo} />
          <div className="ui centered card">
            <div className="content">
              <div className="header">{this.props.applicationInfo.product}</div>
            </div>
            <div className="extra content">
              <i className="check circle green icon"></i>
              up and running
            </div>
          </div>
        </div>
      </div>
    );
  }
}
