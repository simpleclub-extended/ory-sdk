"""
    Ory APIs

    Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers.   # noqa: E501

    The version of the OpenAPI document: v0.2.0-alpha.23
    Contact: support@ory.sh
    Generated by: https://openapi-generator.tech
"""


import sys
import unittest

import ory_client
from ory_client.model.normalized_project_revision import NormalizedProjectRevision
from ory_client.model.project_revisions import ProjectRevisions
from ory_client.model.string_slice_json_format import StringSliceJSONFormat
globals()['NormalizedProjectRevision'] = NormalizedProjectRevision
globals()['ProjectRevisions'] = ProjectRevisions
globals()['StringSliceJSONFormat'] = StringSliceJSONFormat
from ory_client.model.normalized_project import NormalizedProject


class TestNormalizedProject(unittest.TestCase):
    """NormalizedProject unit test stubs"""

    def setUp(self):
        pass

    def tearDown(self):
        pass

    def testNormalizedProject(self):
        """Test NormalizedProject"""
        # FIXME: construct object with mandatory attributes with example values
        # model = NormalizedProject()  # noqa: E501
        pass


if __name__ == '__main__':
    unittest.main()
