"""
    Ory Identities API

    This is the API specification for Ory Identities with features such as registration, login, recovery, account verification, profile settings, password reset, identity management, session management, email and sms delivery, and more.   # noqa: E501

    The version of the OpenAPI document: v0.11.1
    Contact: office@ory.sh
    Generated by: https://openapi-generator.tech
"""


import sys
import unittest

import ory_kratos_client
from ory_kratos_client.model.recovery_flow_state import RecoveryFlowState
from ory_kratos_client.model.ui_container import UiContainer
globals()['RecoveryFlowState'] = RecoveryFlowState
globals()['UiContainer'] = UiContainer
from ory_kratos_client.model.recovery_flow import RecoveryFlow


class TestRecoveryFlow(unittest.TestCase):
    """RecoveryFlow unit test stubs"""

    def setUp(self):
        pass

    def tearDown(self):
        pass

    def testRecoveryFlow(self):
        """Test RecoveryFlow"""
        # FIXME: construct object with mandatory attributes with example values
        # model = RecoveryFlow()  # noqa: E501
        pass


if __name__ == '__main__':
    unittest.main()
