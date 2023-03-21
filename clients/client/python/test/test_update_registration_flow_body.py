"""
    Ory APIs

    Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers.   # noqa: E501

    The version of the OpenAPI document: v1.1.23
    Contact: support@ory.sh
    Generated by: https://openapi-generator.tech
"""


import sys
import unittest

import ory_client
from ory_client.model.update_registration_flow_with_oidc_method import UpdateRegistrationFlowWithOidcMethod
from ory_client.model.update_registration_flow_with_password_method import UpdateRegistrationFlowWithPasswordMethod
from ory_client.model.update_registration_flow_with_web_authn_method import UpdateRegistrationFlowWithWebAuthnMethod
globals()['UpdateRegistrationFlowWithOidcMethod'] = UpdateRegistrationFlowWithOidcMethod
globals()['UpdateRegistrationFlowWithPasswordMethod'] = UpdateRegistrationFlowWithPasswordMethod
globals()['UpdateRegistrationFlowWithWebAuthnMethod'] = UpdateRegistrationFlowWithWebAuthnMethod
from ory_client.model.update_registration_flow_body import UpdateRegistrationFlowBody


class TestUpdateRegistrationFlowBody(unittest.TestCase):
    """UpdateRegistrationFlowBody unit test stubs"""

    def setUp(self):
        pass

    def tearDown(self):
        pass

    def testUpdateRegistrationFlowBody(self):
        """Test UpdateRegistrationFlowBody"""
        # FIXME: construct object with mandatory attributes with example values
        # model = UpdateRegistrationFlowBody()  # noqa: E501
        pass


if __name__ == '__main__':
    unittest.main()
